
using Repository_Pattern_Domain.Entites;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo;
using Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo.Clientes;

namespace Repository_Pattern_Infra_DAL.Repositories.Clientes
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(
            ISelectRepository<Cliente> selectRepository, 
            IInsertRepository<Cliente> insertRepository, 
            IUpdateRepository<Cliente> updateRepository, 
            IDeleteRepository<Cliente> deleteRepository) : base(selectRepository, insertRepository, updateRepository, deleteRepository)
        {
        }
    }
}
