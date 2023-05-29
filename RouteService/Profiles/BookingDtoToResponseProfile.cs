using AutoMapper;
using RouteService.API.RouteService.Responses;
using RouteService.Domain.Dtos;

namespace RouteService.API.Profiles
{
    public class BookingDtoToResponseProfile : Profile
    {
        public BookingDtoToResponseProfile()
        {
            CreateMap<BookingDto, BookingResponse>();
        }
    }
}
