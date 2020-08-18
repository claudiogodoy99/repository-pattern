using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Repository_Pattern_Infra_DAL.Context
{
    public static class RegisterContext
    {
        public static IServiceCollection AddContextDataBase(this IServiceCollection services,  IConfiguration configuration) 
        {
            services.AddScoped<IDbConnection>(s => new SqlConnection(configuration.GetConnectionString("deafultConnection")));
            return services;
        }
    }
}
