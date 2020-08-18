

using Dapper;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo;
using System.Data;
using System.Threading.Tasks;

namespace Repository_Pattern_Infra_DAL.Repositories
{
    public class UpdateRepository<T> : IUpdateRepository<T> where T : class
    {
        private readonly IDbConnection dbConnection;
        public UpdateRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task UpdateAsync(T entity)
        {
            await dbConnection.UpdateAsync(entity);
        }
    }
}
