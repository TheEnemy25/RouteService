namespace RouteService.Domain.Dtos
{
    public class StopDto
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public RouteDto Route { get; set; }
    }
}
