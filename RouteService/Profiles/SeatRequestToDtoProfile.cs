using AutoMapper;
using RouteService.API.RouteService.Requests;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class SeatRequestToDtoProfile : Profile
    {
        public SeatRequestToDtoProfile()
        {
            CreateMap<CreateSeatRequest, SeatDto>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}