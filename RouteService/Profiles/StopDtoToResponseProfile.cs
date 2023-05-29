using AutoMapper;
using RouteService.API.RouteService.Responses;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class StopDtoToResponseProfile : Profile
    {
        public StopDtoToResponseProfile()
        {
            CreateMap<StopDto, StopResponse>();
        }
    }
}
