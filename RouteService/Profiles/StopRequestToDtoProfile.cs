using AutoMapper;
using RouteService.API.RouteService.Requests;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class StopRequestToDtoProfile : Profile
    {
        public StopRequestToDtoProfile()
        {
            CreateMap<CreateStopRequest, StopDto>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
