using Repository_Pattern_Domain.Entites;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository_Pattern_Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Task<int> Insert(Cliente cliente);
        Task Update(Cliente cliente);
        Task Delete(int id);
        Task<IEnumerable<Cliente>> Get();
        Task<Cliente> Get(int id);

    }
}
