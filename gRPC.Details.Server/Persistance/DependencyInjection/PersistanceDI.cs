using gRPC.DeepDive.Service.Application.Contracts;
using gRPC.DeepDive.Service.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace gRPC.DeepDive.Service.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ServiceDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IServiceDbContext, ServiceDbContext>();

            return services;
        }
    }
}
