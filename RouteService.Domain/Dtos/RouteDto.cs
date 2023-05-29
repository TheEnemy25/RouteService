namespace RouteService.Domain.Dtos
{
    public class RouteDto
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public string Driver { get; set; }
        public string Bus { get; set; }
        public ICollection<StopDto> Stops { get; set; }
        public ICollection<SeatDto> Seats { get; set; }
    }
}
