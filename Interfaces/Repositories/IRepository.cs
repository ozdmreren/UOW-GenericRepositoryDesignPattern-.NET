using UnitOfWorkRepositoryPattern.Common;
using UnitOfWorkRepositoryPattern.Models;

namespace UnitOfWorkRepositoryPattern.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        public Task<T> AddAsync(T entity);
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(Guid id);
    }
}