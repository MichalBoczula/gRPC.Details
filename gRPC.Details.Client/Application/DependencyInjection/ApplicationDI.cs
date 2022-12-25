using MediatR;
using System.Reflection;

namespace gRPC.Details.Client.Application.DependencyInjection
{
    internal static class ApplicationDI
    {
        internal static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
