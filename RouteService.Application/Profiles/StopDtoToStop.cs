using AutoMapper;
using RouteService.Domain.Dtos;
using RouteService.Domain.Entities;

namespace RouteService.Application.Profiles
{
    public class StopDtoToStop : Profile
    {
        public StopDtoToStop()
        {
            CreateMap<StopDto, Stop>().ReverseMap();
        }
    }
}
