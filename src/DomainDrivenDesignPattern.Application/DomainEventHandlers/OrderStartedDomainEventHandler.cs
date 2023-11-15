using DomainDrivenDesignPattern.Application.Repository;
using DomainDrivenDesignPattern.Domain.AggregateModels.BuyerModels;
using DomainDrivenDesignPattern.Domain.Events;
using MediatR;

namespace DomainDrivenDesignPattern.Application.DomainEventHandlers;

public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
{
    private readonly IBuyerRepository buyerRepository;

    public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
    {
        this.buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
    }

    public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
    {
        if (notification.Order.UserName == "")
        {
            var buyer = new Buyer(notification.Order.UserName);
        }

        return Task.CompletedTask;
    }
}
