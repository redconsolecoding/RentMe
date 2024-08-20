using Application.Services.Administration.Service.Command.Delete;
using FluentValidation;

namespace Application.Validation.Administration.Service
{
    public class DeleteServiceRequestValidator : AbstractValidator<DeleteServiceRequest>
    {
        public DeleteServiceRequestValidator()
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
