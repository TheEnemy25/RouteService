using Ardalis.Specification;
using RouteService.Domain.Entities;

namespace RouteService.Application.Specifications
{
    public class GetRouteWithoutSeatSpecification : Specification<Route>
    {
        public GetRouteWithoutSeatSpecification()
        {
            Query.Where(r => r.Seats.Count == 0);
        }
    }
}