using Ardalis.Specification;
using RouteService.Domain.Dtos;
using RouteService.Domain.Entities;

namespace RouteService.Application.Specifications
{
    public class UpdateRouteSpecification : Specification<Route>
    {
        public UpdateRouteSpecification(RouteDto routeDto)
        {
            Query.Where(r => r.Id == routeDto.Id);
        }
    }
}