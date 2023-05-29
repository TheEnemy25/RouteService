namespace RouteService.Domain.Dtos
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int SeatId { get; set; }
        public string TicketCode { get; set; }
        public StopDto From { get; set; }
        public StopDto To { get; set; }
    }
}
