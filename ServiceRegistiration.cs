using UnitOfWorkRepositoryPattern.Interfaces.Repositories;
using UnitOfWorkRepositoryPattern.Repositories;

namespace UnitOfWorkRepositoryPattern
{
    public static class ServiceRegistiration
    {
        public static void AddServiceRegistiration(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }    
}