﻿namespace RouteService.Application.Features.Routes.Commands.CreateRide
{
    public class CreateRideDto
    {
        public int Id { get; set; }
        public string RouteId { get; set; } = string.Empty;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public int NumberOfSeats { get; set; }
        public int SeatsAvailable { get; set; }
    }
}
