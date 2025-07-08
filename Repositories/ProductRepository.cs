using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPattern.Context;
using UnitOfWorkRepositoryPattern.Interfaces.Repositories;
using UnitOfWorkRepositoryPattern.Models;

namespace UnitOfWorkRepositoryPattern.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context) => _context = context;

        public async Task<IEnumerable<Product>> GetPagedProductsAsync(int pageNumber, int pageSize)
        {
            return await _context.Products.Take(pageSize).ToListAsync();
        }
    }
}