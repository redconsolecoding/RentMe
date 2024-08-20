using Application.Services.Catalog.RoomType.Command.Add;
using Application.Services.Catalog.RoomType.Command.Delete;
using Application.Services.Catalog.RoomType.Command.Update;
using Application.Services.Catalog.RoomType.Queries.Get;
using Application.Services.Catalog.RoomType.Queries.GetById;
using Domain.Common;
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
        public async Task<IResult> CreateRoomType(RoomType roomType)
        {
            var result = await _mediator.Send(new CreateRoomTypeRequest() { RoomType = roomType });
            if (result.IsSuccess)
            {
                return Results.Ok(result.Value);
            }
            return Results.BadRequest();
        }

        [HttpPut]
        public async Task<IResult> UpdateRoomType(RoomType roomType)
        {
            var result = await _mediator.Send(new UpdateRoomTypeRequest() { RoomType = roomType });
            if (result.IsSuccess)
            {
                return Results.Ok();
            }
            return Results.BadRequest();
        }

        [HttpDelete]
        public async Task<IResult> DeleteRoomType(RoomType roomType)
        {
            var result = await _mediator.Send(new DeleteRoomTypeRequest() { RoomType = roomType });
            if (result.IsSuccess)
            {
                return Results.Ok();
            }
            return Results.BadRequest();
        }

        [HttpGet]
        public async Task<IResult> GetRoomTypes()
        {
            var result = await _mediator.Send(new GetRoomTypesQuery());
            if (result.IsSuccess)
            {
                return Results.Ok(result.Value);
            }
            return Results.BadRequest();
        }

        [HttpGet(":id")]
        public async Task<IResult> GetRoomTypeById([FromQuery] int id)
        {
            var result = await _mediator.Send(new GetRoomTypeByIdQuery() { Id = id });
            if (result.IsSuccess)
            {
                return Results.Ok(result.Value);
            }
            return Results.NotFound(result.Error);
        }
    }
}
