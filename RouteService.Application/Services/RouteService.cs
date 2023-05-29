using AutoMapper;
using RouteService.Application.Exceptions;
using RouteService.Application.Services.Interface;
using RouteService.Application.Specifications;
using RouteService.Domain.Dtos;
using RouteService.Domain.Entities;
using RouteService.Domain.Repositories;
using RouteService.Domain.Specifications;

namespace RouteService.Application.Services
{
    public class RouteService : IRouteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RouteService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ICollection<RouteDto>> GetAvailableRoutesAsync(RouteSearchParamsDto routeSearchParamsDto)
        {
            var specification = new GetAvailableRoutesSpecification(routeSearchParamsDto);
            var routes = await _unitOfWork.RouteRepository.GetManyAsync(specification);
            return _mapper.Map<List<RouteDto>>(routes);
        }

        public async Task<RouteDto> BookRouteAsync(BookRouteParamsDto bookRouteParamsDto)
        {
            var specification = new BookRouteSpecification(bookRouteParamsDto);
            var route = await _unitOfWork.RouteRepository.GetSingleAsync(specification);
            if (route == null)
                throw new NotFoundException("Route not found.");

            // Logic for booking the route

            _unitOfWork.RouteRepository.UpdateAsync(route);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<RouteDto>(route);
        }

        public async Task<RouteDto> CreateRouteAsync(RouteDto routeDto)
        {
            var route = _mapper.Map<Route>(routeDto);
            var createdRoute = await _unitOfWork.RouteRepository.CreateAsync(route);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<RouteDto>(createdRoute);
        }

        public async Task<RouteDto> GetRouteByIdAsync(int routeId)
        {
            var specification = new GetRouteByIdSpecification(routeId);
            var route = await _unitOfWork.RouteRepository.GetSingleAsync(specification);
            if (route == null)
                throw new NotFoundException("Route not found.");

            return _mapper.Map<RouteDto>(route);
        }

        public async Task<RouteDto> GetRouteByIdWithAllDataAsync(int routeId)
        {
            var specification = new GetRouteByIdWithAllDataSpecification(routeId);
            var route = await _unitOfWork.RouteRepository.GetSingleAsync(specification);
            if (route == null)
                throw new NotFoundException("Route not found.");

            return _mapper.Map<RouteDto>(route);
        }

        public async Task UpdateRouteAsync(RouteDto routeDto)
        {
            var specification = new UpdateRouteSpecification(routeDto);
            var route = await _unitOfWork.RouteRepository.GetSingleAsync(specification);
            if (route == null)
                throw new NotFoundException("Route not found.");

            _mapper.Map(routeDto, route);
            _unitOfWork.RouteRepository.UpdateAsync(route);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteRouteAsync(int routeId)
        {
            var specification = new DeleteRouteSpecification(routeId);
            var route = await _unitOfWork.RouteRepository.GetSingleAsync(specification);
            if (route == null)
                throw new NotFoundException("Route not found.");

            _unitOfWork.RouteRepository.DeleteAsync(route.Id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
