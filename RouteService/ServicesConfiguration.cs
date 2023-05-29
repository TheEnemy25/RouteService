using ETicket.RouteService.API.Profiles;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;
using RouteService.API.Profiles;
using RouteService.API.RouteService.Requests;
using RouteService.API.Validators;
using RouteService.Application.Services.Interface;
using RouteService.Domain.Repositories;
using RouteService.Infrastructure;

namespace RouteService.API
{
    public static class ServicesConfiguration
    {
        private static IConfiguration _configuration;
        internal static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public static void AddAppServices(this IServiceCollection services)
        {
            // Database services
            services.AddDbContext<RouteServiceContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Application services
            services.AddScoped<IRouteService, Application.Services.RouteService>();

            //Add mapping services 
            services.AddAutoMapper(typeof(BookingDtoToResponseProfile),
                       typeof(BookingRequestToDtoProfile),
                       typeof(GetAvailableSeatsDtoToResponseProfile),
                       typeof(RouteDtoToResponseProfile),
                       typeof(SeatDtoToResponseProfile),
                       typeof(StopDtoToResponseProfile),
                       typeof(StopRequestToDtoProfile));

            services.AddFluentValidationAutoValidation();
            services.AddScoped<IValidator<CreateBookingRequest>, CreateBookingRequestValidator>();
            services.AddScoped<IValidator<CreateRouteRequest>, CreateRouteRequestValidator>();
            services.AddScoped<IValidator<CreateSeatRequest>, CreateSeatRequestValidator>();
            services.AddScoped<IValidator<CreateStopRequest>, CreateStopRequestValidator>();
            services.AddScoped<IValidator<GetAvailableSeatsRequest>, GetAvailableSeatsRequestValidator>();
            services.AddScoped<IValidator<UpdateBookingRequest>, UpdateBookingRequestValidator>();
        }
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("V1", new OpenApiInfo
                {
                    Version = "V1",
                    Title = "RouteService",
                    Description = "RouteService Web Api"
                });
            });
        }
    }
}

