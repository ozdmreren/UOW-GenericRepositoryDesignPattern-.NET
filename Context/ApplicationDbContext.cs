using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPattern.Interfaces.Context;
using UnitOfWorkRepositoryPattern.Models;

namespace UnitOfWorkRepositoryPattern.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}

        public DbSet<Product> Products { get; set; }
    }    
}