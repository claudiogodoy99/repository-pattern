

using Dapper;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Repository_Pattern_Infra_DAL.Repositories
{
    public class SelectRepository<T> : ISelectRepository<T> where T : class
    {
        private readonly IDbConnection dbConnection;
        public SelectRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async  Task<IEnumerable<T>> Get()
        {
            return await dbConnection.GetListAsync<T>();
        }

        public async Task<T> Get<IdType>(IdType id)
        {
            return await dbConnection.GetAsync<T>(id);
        }
    }
}
