namespace RouteService.Domain.Dtos
{
    public class BookRouteParamsDto
    {
        public int Id { get; set; }
        public string TicketCode { get; set; }
        public int FromId { get; set; }
        public string From { get; set; }
        public int ToId { get; set; }
        public string To { get; set; }
        public DateTime DepartureTime { get; set; }
        public int Seat { get; set; }
    }
}
