using Ardalis.Result;
using Template.Core.ProjectAggregate;

namespace Template.Core.Interfaces;

public interface IToDoItemSearchService
{
    Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
    Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
