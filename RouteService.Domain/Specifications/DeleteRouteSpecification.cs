using Ardalis.Specification;
using RouteService.Domain.Entities;

namespace RouteService.Application.Specifications
{
    public class DeleteRouteSpecification : Specification<Route>
    {
        public DeleteRouteSpecification(int routeId)
        {
            Query.Where(r => r.Id == routeId);
        }
    }
}