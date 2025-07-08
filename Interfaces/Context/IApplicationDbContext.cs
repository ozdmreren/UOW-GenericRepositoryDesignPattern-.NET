using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPattern.Models;

namespace UnitOfWorkRepositoryPattern.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}