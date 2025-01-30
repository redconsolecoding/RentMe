using Application.Services.Catalog.GuestType.Command.Add;
using Application.Services.Catalog.GuestType.Command.Delete;
using Application.Services.Catalog.GuestType.Command.Update;
using Application.Services.Catalog.GuestType.Queries.Get;
using Application.Services.Catalog.GuestType.Queries.GetById;
using Domain.Entities.Catalogs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;

namespace WebApi.Controllers.Catalog;

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
    [Authorize(Policy = "ModeratorPolicy")]
    public async Task<IResult> CreateGuestType(GuestType guestType)
    {
        var result = await _mediator.Send(
            new CreateGuestTypeRequest { GuestType = guestType }
        );

        if (result.IsSuccess) return Results.Ok(result.Value);
        return Results.BadRequest();
    }

    [HttpPut]
    [Authorize(Policy = "ModeratorPolicy")]
    public async Task<IResult> UpdateGuestType(GuestType guestType)
    {
        var result = await _mediator.Send(
            new UpdateGuestTypeRequest { GuestType = guestType }
        );

        if (result.IsSuccess) return Results.Ok();
        return Results.BadRequest();
    }

    [HttpDelete]
    [Authorize(Policy = "ModeratorPolicy")]
    public async Task<IResult> DeleteGuestType(GuestType guestType)
    {
        var result = await _mediator.Send(
            new DeleteGuestTypeRequest { GuestType = guestType }
        );
        if (result.IsSuccess) return Results.Ok();
        return Results.BadRequest();
    }

    [HttpGet]
    public async Task<IResult> GetGuestTypes([FromQuery] string requestQuery)
    {
        var queryParameters = QueryParser.Parse(requestQuery);

        var result = await _mediator.Send(new GetGuestTypesQuery(queryParameters));

        if (result.IsSuccess) return Results.Ok(result.Value);
        return Results.BadRequest(result.Error);
    }

    [HttpGet(":id")]
    public async Task<IResult> GetGuestTypeById([FromQuery] int id)
    {
        var result = await _mediator.Send(new GetGuestTypeByIdQuery { Id = id });
        if (result.IsSuccess) return Results.Ok(result.Value);
        return Results.NotFound(result.Error);
    }
}