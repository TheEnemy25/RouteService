using AutoMapper;
using RouteService.API.RouteService.Requests;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class GetAvailableSeatsDtoToResponseProfile : Profile
    {
        public GetAvailableSeatsDtoToResponseProfile()
        {
            CreateMap<SeatDto, GetAvailableSeatsRequest>()
                .ForMember(dest => dest.RouteId, opt => opt.MapFrom(src => src.RouteId));
        }
    }
}
