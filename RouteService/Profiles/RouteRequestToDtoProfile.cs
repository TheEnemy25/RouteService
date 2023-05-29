using AutoMapper;
using RouteService.API.RouteService.Requests;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class RouteRequestToDtoProfile : Profile
    {
        public RouteRequestToDtoProfile()
        {
            CreateMap<CreateRouteRequest, RouteDto>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UpdateRouteRequest, RouteDto>();
        }
    }
}
