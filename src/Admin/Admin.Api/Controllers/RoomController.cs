using Admin.Service.EventHandlers.Commands;
using Admin.Service.Queries;
using Admin.Service.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomQueryService _roomQueryService;
        private readonly IMediator _mediator;

        public RoomController(IRoomQueryService roomQueryService, IMediator mediator)
        {
            _roomQueryService = roomQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<RoomDto>> GetRooms()
        {
            return await _roomQueryService.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(RoomCreateCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoom(RoomUpdateCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }

        [HttpPatch]
        public async Task<IActionResult> EnableRoom(RoomEnableCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }
    }
}
