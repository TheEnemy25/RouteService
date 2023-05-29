using Ardalis.Specification;
using RouteService.Domain.Dtos;
using RouteService.Domain.Entities;


namespace RouteService.Application.Specifications
{
    public class GetAvailableRoutesSpecification : Specification<Route>
    {
        public GetAvailableRoutesSpecification(RouteSearchParamsDto routeSearchParamsDto)
        {
            Query.Where(r =>
                r.From == routeSearchParamsDto.From &&
                r.To == routeSearchParamsDto.To &&
                r.DepartureTime.Date == routeSearchParamsDto.DepartureTime.Date &&
                r.AvailableSeats >= routeSearchParamsDto.NumberOfSeats);
        }
    }
}