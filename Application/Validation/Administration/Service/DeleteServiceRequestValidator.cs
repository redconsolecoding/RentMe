using Application.Services.Administration.Service.Command.Delete;
using FluentValidation;

namespace Application.Validation.Administration.Service
{
    public class DeleteServiceRequestValidator : AbstractValidator<DeleteServiceRequest>
    {
        public DeleteServiceRequestValidator()
        {
            RuleFor(p => p.Service).NotEmpty();
        }
    }
}
