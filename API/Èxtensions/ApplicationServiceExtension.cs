using API.Data;
using API.Repositories;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Èxtensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config){
                services.AddScoped<ITokenServiceRepository, TokenService>();
                services.AddDbContext<DataContext>(options =>{
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}