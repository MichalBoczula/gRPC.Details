using gRPC.Details.Client.Application.Contracts;
using gRPC.Details.Client.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace gRPC.Details.Client.Persistance.DependencyInjection
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
