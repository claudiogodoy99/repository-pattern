
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Repository_Pattern_Infra_DAL.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ISelectRepository<T> selectRepository;
        private readonly IInsertRepository<T> insertRepository;
        private readonly IUpdateRepository<T> updateRepository;
        private readonly IDeleteRepository<T> deleteRepository;

        public RepositoryBase(
             ISelectRepository<T> selectRepository
            ,IInsertRepository<T> insertRepository
            ,IUpdateRepository<T> updateRepository
            ,IDeleteRepository<T> deleteRepository)
        {
            this.deleteRepository = deleteRepository;
            this.selectRepository = selectRepository;
            this.updateRepository = updateRepository;
            this.insertRepository = insertRepository;
        }

        public async Task Delete(T entity)
        {
            await deleteRepository.Delete(entity);
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await selectRepository.Get();
        }

        public async Task<T> Get<IdType>(IdType id)
        {
            return await selectRepository.Get(id);
        }

        public async Task<ResultType> Insert<ResultType>(T entity)
        {
            return await insertRepository.Insert<ResultType>(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await updateRepository.UpdateAsync(entity);
        }
    }
}
