namespace RouteService.Domain.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int NumberOfSeats { get; set; }
        public Route Route { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
