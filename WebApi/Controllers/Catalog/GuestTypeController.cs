using Application.Services.Catalog.GuestType.Command.Add;
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
    }
}
