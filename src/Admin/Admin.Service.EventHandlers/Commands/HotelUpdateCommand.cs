﻿
using MediatR;

namespace Admin.Service.EventHandlers.Commands
{
    public class HotelUpdateCommand : INotification
    {
        public int HotelId { get; set; }
        public int HotelTypeId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
