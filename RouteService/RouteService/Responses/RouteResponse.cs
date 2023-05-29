using Microsoft.AspNetCore.Http;

namespace RouteService.API.RouteService.Responses
{
    public class RouteResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
