namespace RouteService.API.RouteService.Responses
{
    public class StopResponse
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}
