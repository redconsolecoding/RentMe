using MediatR;

namespace Application.Services.Administration.Service.Queries.GetById
{
    using Domain.Common;
    using Domain.Entities.Administration;

    public class GetServiceByIdQuery : IRequest<Result<Service>>
    {
        public int Id { get; set; }
    }
}
