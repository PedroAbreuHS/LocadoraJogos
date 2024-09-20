
using LocadoraJogos.Domain.Repositories;
using LocadoraJogos.Infrastructure.Data.Contexts;
using LocadoraJogos.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LocadoraJogos.Infrastructure.Data
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories()
                .AddData(configuration);

            return services;
        }


        //Configuração de conexão com Banco
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("LocadoraJogosConnectionString");

            services.AddDbContext<LocadoraJogosDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }


        //Configuração injeção de dependência Repositories
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IJogoRepository, JogoRepository>();
            services.AddScoped<IAluguelRepository, AluguelRepository>();

            return services;
        }
    }
}
