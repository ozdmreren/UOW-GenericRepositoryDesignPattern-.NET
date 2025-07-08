using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using UnitOfWorkRepositoryPattern.Common;
using UnitOfWorkRepositoryPattern.Context;
using UnitOfWorkRepositoryPattern.Interfaces.Repositories;
using UnitOfWorkRepositoryPattern.Interfaces.UnitOfWork;

namespace UnitOfWorkRepositoryPattern.Repositories
{
    public class Repository<T>(ApplicationDbContext context) : IRepository<T> where T: BaseEntity,new()
    {
        private DbSet<T> Table { get => context.Set<T>(); }
        public async Task<T> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync() => await Table.ToListAsync();
        public async Task<T> GetByIdAsync(Guid id) =>  await Table.FindAsync(id);
    }
}