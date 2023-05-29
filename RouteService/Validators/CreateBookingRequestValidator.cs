using FluentValidation;
using RouteService.API.RouteService.Requests;

namespace RouteService.API.Validators
{
    public class CreateBookingRequestValidator : AbstractValidator<CreateBookingRequest>
    {
        public CreateBookingRequestValidator()
        {
            RuleFor(x => x.SeatId).NotEmpty();
            RuleFor(x => x.PassengerName).NotEmpty().MaximumLength(100);
        }
    }
}
