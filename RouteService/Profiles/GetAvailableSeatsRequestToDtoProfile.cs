using AutoMapper;
using RouteService.API.RouteService.Requests;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class GetAvailableSeatsRequestToDtoProfile : Profile
    {
        public GetAvailableSeatsRequestToDtoProfile()
        {
            CreateMap<GetAvailableSeatsRequest, SeatDto>();
        }
    }
}
