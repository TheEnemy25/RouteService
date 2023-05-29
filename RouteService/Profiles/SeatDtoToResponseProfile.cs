using AutoMapper;
using RouteService.API.RouteService.Responses;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class SeatDtoToResponseProfile : Profile
    {
        public SeatDtoToResponseProfile()
        {
            CreateMap<SeatDto, SeatResponse>();
        }
    }
}
