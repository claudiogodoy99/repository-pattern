using Dapper;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo;
using System.Data;
using System.Threading.Tasks;

namespace Repository_Pattern_Infra_DAL.Repositories
{
    public class InsertRepository<T> : IInsertRepository<T> where T : class
    {
        private readonly IDbConnection dbConnection;
        public InsertRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task<R> Insert<R>(T entity)
        {
            return await dbConnection.InsertAsync<R,T>(entity);
        }
    }
}
