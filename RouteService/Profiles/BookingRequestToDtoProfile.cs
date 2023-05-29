using AutoMapper;
using RouteService.API.RouteService.Requests;
using RouteService.Domain.Dtos;

namespace ETicket.RouteService.API.Profiles
{
    public class BookingRequestToDtoProfile : Profile
    {
        public BookingRequestToDtoProfile()
        {
            CreateMap<CreateBookingRequest, BookingDto>()
                             .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UpdateBookingRequest, BookingDto>();
        }
    }
}
