using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.SAGER;
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
                c.EnableSensitiveDataLogging(); // Habilita o log de dados sensíveis (como valores de parâmetros SQL)
                c.EnableDetailedErrors();       // Habilita erros detalhados
                c.LogTo(Console.WriteLine);     // Opcional: registra as consultas SQL no Console para debugging
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IDadosResultadoPmoRepository, DadosResultadoPmoRepository>();
            services.AddScoped<IPMORepository, PMORepository>();
            services.AddScoped<IInsumoRepostitory, InsumoRepository>();

            return services;
        }
    }
}
