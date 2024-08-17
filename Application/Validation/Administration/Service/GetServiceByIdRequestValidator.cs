using Application.Services.Administration.Service.Queries.GetById;
using FluentValidation;

namespace Application.Validation.Administration.Service
{
    public class GetServiceByIdRequestValidator : AbstractValidator<GetServiceByIdQuery>
    {
        public GetServiceByIdRequestValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
        }
    }
}
