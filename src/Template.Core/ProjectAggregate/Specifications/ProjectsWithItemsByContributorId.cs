﻿using Ardalis.Specification;

namespace Template.Core.ProjectAggregate.Specifications;

public class ProjectsWithItemsByContributorIdSpec : Specification<Project>, ISingleResultSpecification
{
    public ProjectsWithItemsByContributorIdSpec(Guid contributorId)
    {
        Query
            .Where(project => project.Items.Any(item => item.ContributorId == contributorId))
            .Include(project => project.Items);
    }
}
