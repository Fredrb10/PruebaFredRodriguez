﻿namespace Admin.Domain
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public int HotelTypeId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Enabled { get; set; }

    }
}
