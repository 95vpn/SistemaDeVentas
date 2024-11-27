using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PuntoDeVenta.Infraestructura.Persistences.Contexto;

namespace PuntoDeVenta.Infraestructura.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(SisventasContext).Assembly.FullName;

            services.AddDbContext<SisventasContext>(
                options => options.UseSqlServer(
                        configuration.GetConnectionString("SisventasConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);
            return services;
        }       
    }
}
