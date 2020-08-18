using System.Threading.Tasks;

namespace Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo
{
    public interface IUpdateRepository<T> where T : class
    {
        Task UpdateAsync(T entity);
    }
}
