namespace RouteService.Domain.Dtos
{
    public class SeatDto
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int NumberOfSeats { get; set; }
        public RouteDto Route { get; set; }
        public ICollection<BookingDto> Bookings { get; set; }
    }
}
