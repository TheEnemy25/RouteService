using AutoMapper;
using RouteService.Domain.Dtos;
using RouteService.Domain.Entities;

namespace RouteService.Application.Profiles
{
    public class BookingDtoToBooking : Profile
    {
        public BookingDtoToBooking()
        {
            CreateMap<BookingDto, Booking>().ReverseMap();
        }
    }
}
