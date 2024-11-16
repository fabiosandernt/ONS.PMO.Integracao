using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ONS.PMO.Integracao.Domain.Interfaces;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;
using ONS.PMO.Integracao.Infraestructure.Repository;

namespace ONS.PMO.Integracao.Infraestructure
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<WebPmoContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });
            

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IDadosResultadoPmoRepository, DadosResultadoPmoRepository>();                      

            return services;
        }
    }
}
