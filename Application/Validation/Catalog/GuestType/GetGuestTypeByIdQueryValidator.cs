using Application.Services.Catalog.GuestType.Queries.GetById;
using FluentValidation;

namespace Application.Validation.Catalog.GuestType
{
    public class GetGuestTypeByIdQueryValidator : AbstractValidator<GetGuestTypeByIdQuery>
    {
        public GetGuestTypeByIdQueryValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
        }
    }
}
