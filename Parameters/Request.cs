namespace UnitOfWorkRepositoryPatternExample.Parameters
{
    public sealed record Request(
        int PageSize,
        int PageNumber
    );
}