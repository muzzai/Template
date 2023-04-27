using Ardalis.Result;
using Template.Core.ProjectAggregate;

namespace Template.Core.Interfaces;

public interface IToDoItemSearchService
{
    Task<Result<ToDoItem>> GetNextIncompleteItemAsync(Guid projectId);
    Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(Guid projectId, string searchString);
}
