using Application.Services.Catalog.GuestType.Command.Add;
using Application.Services.Catalog.GuestType.Command.Delete;
using Application.Services.Catalog.GuestType.Command.Update;
using Application.Services.Catalog.GuestType.Queries.Get;
using Application.Services.Catalog.GuestType.Queries.GetById;
using Domain.Entities.Catalogs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Catalog
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GuestTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<GuestType> CreateGuestType(GuestType guestType)
        {
            return await _mediator.Send(new CreateGuestTypeRequest() { GuestType = guestType });
        }

        [HttpPut]
        public async Task<IResult> UpdateGuestType(GuestType guestType)
        {
            return Results.Ok(
                await _mediator.Send(new UpdateGuestTypeRequest() { GuestType = guestType })
            );
        }

        [HttpDelete]
        public async Task<IResult> DeleteGuestType(GuestType guestType)
        {
            return Results.Ok(
                await _mediator.Send(new DeleteGuestTypeRequest() { GuestType = guestType })
            );
        }

        [HttpGet]
        public async Task<IEnumerable<GuestType>> GetGuestTypes()
        {
            return await _mediator.Send(new GetGuestTypesQuery());
        }

        [HttpGet(":id")]
        public async Task<GuestType> GetGuestTypeById([FromQuery] int id)
        {
            return await _mediator.Send(new GetGuestTypeByIdQuery() { Id = id });
        }
    }
}
