using Application.Services.Administration.Service.Command.Update;
using FluentValidation;

namespace Application.Validation.Administration.Service
{
    public class UpdateServiceRequestValidator : AbstractValidator<UpdateServiceRequest>
    {
        public UpdateServiceRequestValidator()
        {
            RuleFor(p => p.Service).NotEmpty();
        }
    }
}
