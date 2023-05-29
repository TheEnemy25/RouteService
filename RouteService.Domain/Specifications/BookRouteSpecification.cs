using Ardalis.Specification;
using RouteService.Domain.Dtos;
using RouteService.Domain.Entities;

namespace RouteService.Domain.Specifications
{
    public class BookRouteSpecification : Specification<Route>
    {
        public BookRouteSpecification(BookRouteParamsDto bookRouteParamsDto)
        {
            Query.Where(r => r.Id == bookRouteParamsDto.Id);
        }
    }
}
