using AutoMapper;
using RouteService.API.RouteService.Responses;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class RouteDtoToResponseProfile : Profile
    {
        public RouteDtoToResponseProfile()
        {
            CreateMap<RouteDto, RouteResponse>();
        }
    }
}
