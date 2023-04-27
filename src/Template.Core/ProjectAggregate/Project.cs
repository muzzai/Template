﻿using Ardalis.GuardClauses;
using SharedKernel;
using SharedKernel.Interfaces;
using Template.Core.ProjectAggregate.Events;

namespace Template.Core.ProjectAggregate;

public class Project : EntityBase<Guid>, IAggregateRoot
{
    public string Name { get; private set; }

    private readonly List<ToDoItem> _items = new();
    public IEnumerable<ToDoItem> Items => _items.AsReadOnly();
    public ProjectStatus Status => _items.All(i => i.IsDone) ? ProjectStatus.Complete : ProjectStatus.InProgress;

    public PriorityStatus Priority { get; }

    public Project(string name, PriorityStatus priority)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));
        Priority = priority;
    }

    public void AddItem(ToDoItem newItem)
    {
        Guard.Against.Null(newItem, nameof(newItem));
        _items.Add(newItem);

        var newItemAddedEvent = new NewItemAddedEvent(this, newItem);
        base.RegisterDomainEvent(newItemAddedEvent);
    }

    public void UpdateName(string newName)
    {
        Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
    }
}
