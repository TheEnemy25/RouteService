namespace RouteService.API.RouteService.Requests
{
    public class CreateStopRequest
    {
        public int RouteId { get; set; }
        public string Location { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}
