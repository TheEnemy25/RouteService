using FluentValidation;
using RouteService.API.RouteService.Requests;

namespace RouteService.API.Validators
{
    public class UpdateBookingRequestValidator : AbstractValidator<UpdateBookingRequest>
    {
        public UpdateBookingRequestValidator()
        {
            RuleFor(x => x.PassengerName).NotEmpty().MaximumLength(100);
        }
    }
}
