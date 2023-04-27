﻿

using SharedKernel;

namespace Template.Core.ContributorAggregate.Events;

public class ContributorDeletedEvent : DomainEventBase
{
    public Guid ContributorId { get; set; }

    public ContributorDeletedEvent(Guid contributorId)
    {
        ContributorId = contributorId;
    }
}
