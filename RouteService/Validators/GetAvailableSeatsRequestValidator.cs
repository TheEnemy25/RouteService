using FluentValidation;
using RouteService.API.RouteService.Requests;

namespace RouteService.API.Validators
{
    public class GetAvailableSeatsRequestValidator : AbstractValidator<GetAvailableSeatsRequest>
    {
        public GetAvailableSeatsRequestValidator()
        {
            RuleFor(x => x.RouteId).NotEmpty();
        }
    }
}
