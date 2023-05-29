using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using RouteService.Application.Exceptions;

namespace ETicket.RouteService.API.Filters
{
    public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private readonly IDictionary<Type, Action<ExceptionContext>> _exceptionHandlers;

        public ApiExceptionFilterAttribute()
        {
            _exceptionHandlers = new Dictionary<Type, Action<ExceptionContext>>
        {
            {typeof(RouteServiceException), HandleRouteServiceException},
        };
        }

        public override void OnException(ExceptionContext context)
        {
            HandleException(context);

            base.OnException(context);
        }

        private void HandleException(ExceptionContext context)
        {
            Type type = context.Exception.GetType();
            if (_exceptionHandlers.TryGetValue(type, out Action<ExceptionContext>? value))
            {
                value.Invoke(context);

                return;
            }
        }

        private void HandleRouteServiceException(ExceptionContext context)
        {
            var ex = (RouteServiceException)context.Exception;

            context.Result = new ObjectResult(ex.Message)
            {
                StatusCode = ex.StatusCode
            };

            context.ExceptionHandled = true;
        }
    }
}
