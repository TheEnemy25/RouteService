using AutoMapper;
using Microsoft.AspNetCore.Routing;
using RouteService.Domain.Dtos;

namespace RouteService.Application.Profiles
{
    public class RouteDtoToRoute : Profile
    {
        public RouteDtoToRoute()
        {
            CreateMap<RouteDto, Route>().ReverseMap();
        }
    }
}
