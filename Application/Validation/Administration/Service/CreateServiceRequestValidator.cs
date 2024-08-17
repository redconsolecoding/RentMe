using Application.Services.Administration.Service.Command.Add;
using FluentValidation;

namespace Application.Validation.Administration.Service
{
    public class CreateServiceRequestValidator : AbstractValidator<CreateServiceRequest>
    {
        public CreateServiceRequestValidator()
        {
            RuleFor(p => p.Service).NotEmpty();
        }
    }
}
