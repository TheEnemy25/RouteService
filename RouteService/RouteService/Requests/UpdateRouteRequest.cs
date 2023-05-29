using RouteService.Domain.Dtos;

namespace RouteService.API.RouteService.Requests
{
    public class UpdateRouteRequest
    {
        public string Name { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
