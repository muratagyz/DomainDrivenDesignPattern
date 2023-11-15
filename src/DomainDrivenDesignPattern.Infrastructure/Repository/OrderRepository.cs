using DomainDrivenDesignPattern.Application.Repository;

namespace DomainDrivenDesignPattern.Infrastructure.Repository;

public class OrderRepository : IOrderRepository
{
    public Task<int> SaveChangesAsync()
    {
        return Task.FromResult(1);
    }
}
