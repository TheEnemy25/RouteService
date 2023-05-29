using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RouteService.API.RouteService.Requests;
using RouteService.API.RouteService.Responses;
using RouteService.Application.Exceptions;
using RouteService.Application.Services.Interface;
using RouteService.Domain.Dtos;

namespace RouteService.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RouteServiceController : ControllerBase
    {
        private readonly IRouteService _routeService;
        private readonly IMapper _mapper;

        public RouteServiceController(IRouteService routeService, IMapper mapper)
        {
            _routeService = routeService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoute(int id)
        {
            try
            {
                var routeDto = await _routeService.GetRouteByIdAsync(id);

                if (routeDto == null)
                {
                    throw new RouteServiceException("Route not found", 404);
                }

                var routeResponse = _mapper.Map<RouteDto, RouteResponse>(routeDto);

                return Ok(routeResponse);
            }
            catch (RouteServiceException ex)
            {
                return StatusCode(ex.StatusCode, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoute(CreateRouteRequest createRouteRequest)
        {
            try
            {
                var routeDto = _mapper.Map<CreateRouteRequest, RouteDto>(createRouteRequest);

                var createdRouteDto = await _routeService.CreateRouteAsync(routeDto);

                var createdRouteResponse = _mapper.Map<RouteDto, RouteResponse>(createdRouteDto);

                return CreatedAtAction("GetRoute", new { id = createdRouteResponse.Id }, createdRouteResponse);
            }
            catch (RouteServiceException ex)
            {
                return StatusCode(ex.StatusCode, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
