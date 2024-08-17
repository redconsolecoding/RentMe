using Application.Services.Catalog.RoomType.Command.Add;
using Application.Services.Catalog.RoomType.Command.Delete;
using Application.Services.Catalog.RoomType.Command.Update;
using Application.Services.Catalog.RoomType.Queries.Get;
using Application.Services.Catalog.RoomType.Queries.GetById;
using Domain.Entities.Catalogs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Catalog
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<RoomType> CreateRoomType(RoomType roomType)
        {
            return await _mediator.Send(new CreateRoomTypeRequest() { RoomType = roomType });
        }

        [HttpPut]
        public async Task<IResult> UpdateRoomType(RoomType roomType)
        {
            return Results.Ok(
                await _mediator.Send(new UpdateRoomTypeRequest() { RoomType = roomType })
            );
        }

        [HttpDelete]
        public async Task<IResult> DeleteRoomType(RoomType roomType)
        {
            return Results.Ok(
                await _mediator.Send(new DeleteRoomTypeRequest() { RoomType = roomType })
            );
        }

        [HttpGet]
        public async Task<IEnumerable<RoomType>> GetRoomTypes()
        {
            return await _mediator.Send(new GetRoomTypesQuery());
        }

        [HttpGet(":id")]
        public async Task<RoomType> GetRoomTypeById([FromQuery] int id)
        {
            return await _mediator.Send(new GetRoomTypeByIdQuery() { Id = id });
        }
    }
}
