using Booking.Domain;
using Booking.Service.EventHandlers.Commands;
using Booking.Service.Queries;
using Booking.Service.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationQueryService _hotelQueryService;
        private readonly IMediator _mediator;

        public ReservationController(IReservationQueryService hotelQueryService, IMediator mediator)
        {
            _hotelQueryService = hotelQueryService;
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<AvailableHotelsDto>> GetHotelsAvailability(CheckHotels consult)
        {
            return await _hotelQueryService.GetAvailableHotel(consult);
        }

        [HttpGet]
        [Route("ReservationxHotel/{hotelId}")]

        public async Task<List<ReservationDto>> GetReservationxHotel(int hotelId)
        {
            return await _hotelQueryService.GetReservationsHotel(hotelId);
        }

        [HttpGet]
        [Route("GetReservation/{reservationId}")]
        public IEnumerable<ReservationDetail> GetReservation(int reservationId)
        {
            return _hotelQueryService.Reservation(reservationId);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(ReservationCreateCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }


       
    }
}
