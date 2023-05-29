using AutoMapper;
using RouteService.Domain.Dtos;
using RouteService.Domain.Entities;

namespace RouteService.Application.Profiles
{
    public class SeatDtoToSeat : Profile
    {
        public SeatDtoToSeat()
        {
            CreateMap<SeatDto, Seat>().ReverseMap();
        }
    }
}
