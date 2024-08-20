using Application.Services.Administration.Service.Command.Add;
using FluentValidation;

namespace Application.Validation.Administration.Service
{
    public class CreateServiceRequestValidator : AbstractValidator<CreateServiceRequest>
    {
        public CreateServiceRequestValidator()
        {
            RuleFor(e => e.Service.Name)
                .NotEmpty()
                .WithMessage("Name is required.")
                .MaximumLength(200)
                .WithMessage("Maximum length is 200 characters.");

            RuleFor(e => e.Service.Price)
                .NotEmpty()
                .WithMessage("Price is required.")
                .PrecisionScale(5, 2, false);
        }
    }
}
