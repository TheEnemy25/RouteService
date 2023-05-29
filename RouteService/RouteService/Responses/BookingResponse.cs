using Microsoft.AspNetCore.Http;

namespace RouteService.API.RouteService.Responses
{
    public class BookingResponse
    {
        public int Id { get; set; }
        public string PassengerName { get; set; }
        public int SeatId { get; set; }
    }
}
