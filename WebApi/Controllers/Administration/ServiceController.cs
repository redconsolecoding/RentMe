using Application.Services.Administration.Service.Command.Add;
using Application.Services.Administration.Service.Command.Delete;
using Application.Services.Administration.Service.Command.Update;
using Application.Services.Administration.Service.Queries.Get;
using Application.Services.Administration.Service.Queries.GetById;
using Domain.Entities.Administration;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Administration
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Policy = "ModeratorPolicy")]
        public async Task<IResult> CreateService(Service service)
        {
            var result = await _mediator.Send(new CreateServiceRequest() { Service = service });
            if (result.IsSuccess)
            {
                return Results.Ok(result.Value);
            }
            return Results.BadRequest();
        }

        [HttpPut]
        [Authorize(Policy = "ModeratorPolicy")]
        public async Task<IResult> UpdateService(Service service)
        {
            var result = await _mediator.Send(new UpdateServiceRequest() { Service = service });
            if (result.IsSuccess)
            {
                return Results.Ok();
            }
            return Results.BadRequest();
        }

        [HttpDelete]
        [Authorize(Policy = "ModeratorPolicy")]
        public async Task<IResult> DeleteService(Service service)
        {
            var result = await _mediator.Send(new DeleteServiceRequest() { Service = service });
            if (result.IsSuccess)
            {
                return Results.Ok();
            }
            return Results.BadRequest();
        }

        [HttpGet]
        public async Task<IResult> GetServices()
        {
            var result = await _mediator.Send(new GetServicesQuery());
            if (result.IsSuccess)
            {
                return Results.Ok(result.Value);
            }
            return Results.BadRequest();
        }

        [HttpGet(":id")]
        public async Task<IResult> GetServiceById([FromQuery] int id)
        {
            var result = await _mediator.Send(new GetServiceByIdQuery() { Id = id });
            if (result.IsSuccess)
            {
                return Results.Ok(result.Value);
            }
            return Results.BadRequest(result.Error);
        }
    }
}
