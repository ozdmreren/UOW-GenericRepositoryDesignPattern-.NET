using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using UnitOfWorkRepositoryPattern.Context;
using UnitOfWorkRepositoryPattern.Interfaces.Repositories;
using UnitOfWorkRepositoryPattern.Interfaces.UnitOfWork;

namespace UnitOfWorkRepositoryPattern.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context,IProductRepository productRepository)
        {
            _context = context;
            ProductRepository = productRepository;
        }
        public IProductRepository ProductRepository { get; }

        public async Task<IDbContextTransaction> BeginTransaction() => await _context.Database.BeginTransactionAsync();

        public  void Dispose()
        {
            _context.Dispose();
        }
    }
}