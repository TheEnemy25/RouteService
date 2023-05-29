using RouteService.Domain.Entities;
using RouteService.Domain.Repositories;

namespace RouteService.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RouteServiceContext _context;
        private IBaseRepository<Booking> _bookingRepository;
        private IBaseRepository<Route> _routeRepository;
        private IBaseRepository<Stop> _stopRepository;
        private IBaseRepository<Seat> _seatRepository;

        public UnitOfWork(RouteServiceContext context)
        {
            _context = context;
        }

        public IBaseRepository<Booking> BookingRepository
        {
            get
            {
                if (_bookingRepository == null)
                {
                    _bookingRepository = new BaseRepository<Booking>(_context);
                }
                return _bookingRepository;
            }
        }

        public IBaseRepository<Route> RouteRepository
        {
            get
            {
                if (_routeRepository == null)
                {
                    _routeRepository = new BaseRepository<Route>(_context);
                }
                return _routeRepository;
            }
        }

        public IBaseRepository<Stop> StopRepository
        {
            get
            {
                if (_stopRepository == null)
                {
                    _stopRepository = new BaseRepository<Stop>(_context);
                }
                return _stopRepository;
            }
        }

        public IBaseRepository<Seat> SeatRepository
        {
            get
            {
                if (_seatRepository == null)
                {
                    _seatRepository = new BaseRepository<Seat>(_context);
                }
                return _seatRepository;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}


