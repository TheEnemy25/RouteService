using RouteService.Domain.Entities;

namespace RouteService.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Booking> BookingRepository { get; }
        IBaseRepository<Route> RouteRepository { get; }
        IBaseRepository<Stop> StopRepository { get; }
        IBaseRepository<Seat> SeatRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
