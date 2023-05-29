using Ardalis.Specification;
using RouteService.Domain.Entities;

namespace RouteService.Application.Specifications
{
    public class GetRouteByIdSpecification : Specification<Route>
    {
        public GetRouteByIdSpecification(int routeId)
        {
            Query.Where(r => r.Id == routeId);
        }
    }
}