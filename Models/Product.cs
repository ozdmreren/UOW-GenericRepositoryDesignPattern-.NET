using UnitOfWorkRepositoryPattern.Common;

namespace UnitOfWorkRepositoryPattern.Models
{
    public sealed class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
    }
}