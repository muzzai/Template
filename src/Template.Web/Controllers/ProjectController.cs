/*
using Template.Core.ProjectAggregate;
using Template.Core.ProjectAggregate.Specifications;

using Template.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SharedKernel.Interfaces;

namespace Template.Web.Controllers;

[Route("[controller]")]
public class ProjectController : Controller
{
    private readonly IRepository<Project> _projectRepository;

    public ProjectController(IRepository<Project> projectRepository)
    {
        _projectRepository = projectRepository;
    }

    // GET project/{projectId?}
    [HttpGet("{projectId:int}")]
    public async Task<IActionResult> Index(int projectId = 1)
    {
        var spec = new ProjectByIdWithItemsSpec(projectId);
        var project = await _projectRepository.FirstOrDefaultAsync(spec);
        if (project == null)
        {
            return NotFound();
        }

        var dto = new ProjectViewModel
        {
            Id = project.Id,
            Name = project.Name,
            Items = project.Items
                .Select(item => ToDoItemViewModel.FromToDoItem(item))
                .ToList()
        };
        return View(dto);
    }
}
*/
