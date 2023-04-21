using Ardalis.Specification;

namespace Template.Core.ProjectAggregate.Specifications;

public class IncompleteItemsSpec : Specification<ToDoItem>
{
    public IncompleteItemsSpec()
    {
        Query.Where(item => !item.IsDone);
    }
}
