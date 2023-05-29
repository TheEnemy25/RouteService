using FluentValidation;
using RouteService.API.RouteService.Requests;

namespace RouteService.API.Validators
{
    public class CreateSeatRequestValidator : AbstractValidator<CreateSeatRequest>
    {
        public CreateSeatRequestValidator()
        {
            RuleFor(x => x.RouteId).NotEmpty();
            RuleFor(x => x.Number).NotEmpty().MaximumLength(10);
        }
    }
}
