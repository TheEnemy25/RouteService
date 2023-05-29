using RouteService.Domain.Dtos;

namespace RouteService.Application.Services.Interface
{
    public interface IRouteService
    {
        Task<ICollection<RouteDto>> GetAvailableRoutesAsync(RouteSearchParamsDto routeSearchParamsDto);
        Task<RouteDto> BookRouteAsync(BookRouteParamsDto bookRouteParamsDto);
        Task<RouteDto> CreateRouteAsync(RouteDto routeDto);
        Task<RouteDto> GetRouteByIdAsync(int routeId);
        Task<RouteDto> GetRouteByIdWithAllDataAsync(int routeId);
        Task UpdateRouteAsync(RouteDto routeDto);
        Task DeleteRouteAsync(int routeId);
    }
}
