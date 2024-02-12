using Admin.Service.EventHandlers.Commands;
using Admin.Service.Queries;
using Admin.Service.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelQueryService _hotelQueryService;
        private readonly IMediator _mediator;
        
        public HotelController(IHotelQueryService hotelQueryService, IMediator mediator)
        {
           _hotelQueryService = hotelQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<HotelDto>> GetHotels()
        {
           return await _hotelQueryService.GetAllHotels();
        }

        [HttpPost]
        public async Task<IActionResult> CreateHotel(HotelCreateCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHotel(HotelUpdateCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }

        [HttpPatch]
        public async Task<IActionResult> EnableHotel(HotelEnableCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }
    }
}
