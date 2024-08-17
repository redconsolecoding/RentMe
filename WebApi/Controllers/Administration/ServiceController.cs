using Application.Services.Administration.Service.Command.Add;
using Application.Services.Administration.Service.Command.Delete;
using Application.Services.Administration.Service.Command.Update;
using Application.Services.Administration.Service.Queries.Get;
using Application.Services.Administration.Service.Queries.GetById;
using Domain.Entities.Administration;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Administration
{
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<Service> CreateService(Service service)
        {
            return await _mediator.Send(new CreateServiceRequest() { Service = service });
        }

        [HttpPut]
        public async Task<IResult> UpdateService(Service service)
        {
            return Results.Ok(
                await _mediator.Send(new UpdateServiceRequest() { Service = service })
            );
        }

        [HttpDelete]
        public async Task<IResult> DeleteService(Service service)
        {
            return Results.Ok(
                await _mediator.Send(new DeleteServiceRequest() { Service = service })
            );
        }

        [HttpGet]
        public async Task<IEnumerable<Service>> GetServices()
        {
            return await _mediator.Send(new GetServicesQuery());
        }

        [HttpGet(":id")]
        public async Task<Service> GetServiceById([FromQuery] int id)
        {
            return await _mediator.Send(new GetServiceByIdQuery() { Id = id });
        }
    }
}
