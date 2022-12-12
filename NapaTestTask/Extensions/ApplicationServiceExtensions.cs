using Database.Contexts;
using Domain.Intefaces;
using Microsoft.EntityFrameworkCore;
using Service.Services;

namespace NapaTestTask.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
