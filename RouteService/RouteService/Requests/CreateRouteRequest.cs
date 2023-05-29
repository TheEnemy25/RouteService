namespace RouteService.API.RouteService.Requests
{
    public class CreateRouteRequest
    {
        public string Name { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
