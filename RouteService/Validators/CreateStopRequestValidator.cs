using FluentValidation;
using RouteService.API.RouteService.Requests;

namespace RouteService.API.Validators
{
    public class CreateStopRequestValidator : AbstractValidator<CreateStopRequest>
    {
        public CreateStopRequestValidator()
        {
            RuleFor(x => x.RouteId).NotEmpty();
            RuleFor(x => x.Location).NotEmpty().MaximumLength(100);
            RuleFor(x => x.ArrivalTime).NotEmpty().GreaterThanOrEqualTo(DateTime.UtcNow);
            RuleFor(x => x.DepartureTime).NotEmpty().GreaterThanOrEqualTo(DateTime.UtcNow);
            RuleFor(x => x.DepartureTime).GreaterThan(x => x.ArrivalTime);
        }
    }
}
