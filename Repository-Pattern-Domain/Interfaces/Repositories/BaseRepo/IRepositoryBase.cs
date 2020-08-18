
namespace Repository_Pattern_Domain.Interfaces.Repositories.BaseRepo
{
    public interface IRepositoryBase<T>: 
        IUpdateRepository<T>,
        IInsertRepository<T>,
        ISelectRepository<T>,
        IDeleteRepository<T> where T : class
    {
    }
}
