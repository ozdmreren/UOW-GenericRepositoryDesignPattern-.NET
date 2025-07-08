using Microsoft.EntityFrameworkCore.Storage;
using UnitOfWorkRepositoryPattern.Interfaces.Repositories;

namespace UnitOfWorkRepositoryPattern.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public Task<IDbContextTransaction> BeginTransaction();
        public IProductRepository ProductRepository{ get; }
    }
}