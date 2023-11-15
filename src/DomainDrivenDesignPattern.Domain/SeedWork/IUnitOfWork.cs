namespace DomainDrivenDesignPattern.Domain.SeedWork;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
