

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo
{
    public interface ISelectRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get<IdType>(IdType id);
    }
}
