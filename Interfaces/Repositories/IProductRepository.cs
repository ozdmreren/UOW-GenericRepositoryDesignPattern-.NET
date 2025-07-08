using UnitOfWorkRepositoryPattern.Models;

namespace UnitOfWorkRepositoryPattern.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetPagedProductsAsync(int pageNumber, int pageSize);

    }
}