namespace UnitOfWorkRepositoryPatternExample.Dtos
{
    public record ProductDto(
        string ProductName,
        string Category,
        string Brand,
        int Quantity,
        float UnitPrice
    );
}