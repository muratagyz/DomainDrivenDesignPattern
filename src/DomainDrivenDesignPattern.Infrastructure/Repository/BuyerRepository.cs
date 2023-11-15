using DomainDrivenDesignPattern.Application.Repository;

namespace DomainDrivenDesignPattern.Infrastructure.Repository;

public class BuyerRepository : IBuyerRepository
{
    public Task<int> SaveChangesAsync()
    {
        return Task.FromResult(1);
    }
}
