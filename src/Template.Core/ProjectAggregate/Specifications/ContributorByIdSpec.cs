using Ardalis.Specification;
using Template.Core.ContributorAggregate;

namespace Template.Core.ProjectAggregate.Specifications;

public class ContributorByIdSpec : Specification<Contributor>, ISingleResultSpecification
{
    public ContributorByIdSpec(Guid contributorId)
    {
        Query
            .Where(contributor => contributor.Id == contributorId);
    }
}
