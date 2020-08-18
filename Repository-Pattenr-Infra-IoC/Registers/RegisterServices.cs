using Microsoft.Extensions.DependencyInjection;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo.Clientes;
using Repository_Pattern_Domain.Interfaces.Services;
using Repository_Pattern_Domain.Services;
using Repository_Pattern_Infra_DAL.Repositories;
using Repository_Pattern_Infra_DAL.Repositories.Clientes;

namespace Repository_Pattenr_Infra_IoC.Registers
{
    public static class RegisterServices
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IDeleteRepository<>), typeof(DeleteRepository<>));
            services.AddScoped(typeof(IUpdateRepository<>), typeof(UpdateRepository<>));
            services.AddScoped(typeof(IInsertRepository<>), typeof(InsertRepository<>));
            services.AddScoped(typeof(ISelectRepository<>), typeof(SelectRepository<>));
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
            return services;
        }


    }
}
