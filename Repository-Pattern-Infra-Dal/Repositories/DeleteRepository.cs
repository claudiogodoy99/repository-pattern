using Dapper;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo;
using System.Data;
using System.Threading.Tasks;

namespace Repository_Pattern_Infra_DAL.Repositories
{
    public class DeleteRepository<T> : IDeleteRepository<T> where T : class
    {

        private readonly IDbConnection dbConnection;
        public DeleteRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task Delete(T entity)
        {
            await dbConnection.DeleteAsync(entity);
        }
    }
}
