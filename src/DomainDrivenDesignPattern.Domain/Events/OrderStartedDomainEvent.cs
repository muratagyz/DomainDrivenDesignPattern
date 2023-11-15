﻿using MediatR;

namespace DomainDrivenDesignPattern.Domain.Events;

public class OrderStartedDomainEvent : INotification
{
    public string UserName { get; set; }

    public AggregateModels.OrderModels.Order Order { get; set; }

    public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
    {
        UserName = userName;
        Order = order ?? throw new ArgumentNullException(nameof(order));
    }
}
