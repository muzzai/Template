

using SharedKernel;

namespace Template.Core.ContributorAggregate.Events;

public class ContributorDeletedEvent : DomainEventBase
{
    public int ContributorId { get; set; }

    public ContributorDeletedEvent(int contributorId)
    {
        ContributorId = contributorId;
    }
}
