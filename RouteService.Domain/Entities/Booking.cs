namespace RouteService.Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int SeatId { get; set; }
        public string TicketCode { get; set; }
        public Stop From { get; set; }
        public Stop To { get; set; }
    }
}
