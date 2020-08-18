

using System.Threading.Tasks;

namespace Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo
{
    public interface IDeleteRepository<T> where T : class
    {
        Task Delete(T entity);
    }
}
