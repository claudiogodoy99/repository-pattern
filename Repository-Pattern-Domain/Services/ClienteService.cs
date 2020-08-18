

using Repository_Pattern_Domain.Entites;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo.Clientes;
using Repository_Pattern_Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Repository_Pattern_Domain.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteRepository clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public async Task Delete(int id)
        {
            await clienteRepository.Delete(new Cliente { Id = id });
        }

        public async Task<IEnumerable<Cliente>> Get()
        {
            return await clienteRepository.Get();
        }

        public async Task<Cliente> Get(int id)
        {
            return await clienteRepository.Get(id);
        }

        public async Task<int> Insert(Cliente cliente)
        {
            return await clienteRepository.Insert<int>(cliente);
        }

        public async Task Update(Cliente cliente)
        {
            await clienteRepository.UpdateAsync(cliente);
        }
    }
}
