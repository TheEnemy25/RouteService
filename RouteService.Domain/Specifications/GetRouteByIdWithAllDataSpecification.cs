using Ardalis.Specification;
using RouteService.Domain.Entities;

namespace RouteService.Application.Specifications
{
    public class GetRouteByIdWithAllDataSpecification : Specification<Route>
    {
        public GetRouteByIdWithAllDataSpecification(int routeId)
        {
            Query.Where(r => r.Id == routeId)
                 .Include(r => r.Stops)
                 .Include(r => r.Seats);
        }
    }
}