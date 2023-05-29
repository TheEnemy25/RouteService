namespace RouteService.Domain.Entities
{
    public class Route
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
        public ICollection<Stop> Stops { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
