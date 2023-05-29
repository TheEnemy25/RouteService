using FluentValidation;
using RouteService.API.RouteService.Requests;

namespace RouteService.API.Validators
{
    public class CreateRouteRequestValidator : AbstractValidator<CreateRouteRequest>
    {
        public CreateRouteRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.StartLocation).NotEmpty().MaximumLength(100);
            RuleFor(x => x.EndLocation).NotEmpty().MaximumLength(100);
            RuleFor(x => x.DepartureTime).NotEmpty().GreaterThanOrEqualTo(DateTime.UtcNow);
            RuleFor(x => x.ArrivalTime).NotEmpty().GreaterThanOrEqualTo(DateTime.UtcNow);
            RuleFor(x => x.DepartureTime).LessThan(x => x.ArrivalTime);
        }
    }
}
