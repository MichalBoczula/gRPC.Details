using gRPC.Details.Service.Application.Contracts;
using gRPC.Details.Service.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace gRPC.Details.Service.Persistance.DependencyInjection
{
    internal static class PersistanceDI
    {
        internal static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
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
