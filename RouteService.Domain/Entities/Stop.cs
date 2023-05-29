namespace RouteService.Domain.Entities
{
    public class Stop
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public Route Route { get; set; }
    }
}
