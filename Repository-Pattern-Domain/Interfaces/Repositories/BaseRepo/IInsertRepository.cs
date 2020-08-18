using System.Threading.Tasks;

namespace Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo
{
    public interface IInsertRepository<T> where T : class
    {
        Task<R> Insert<R>(T entity);
    }
}
