﻿using Template.Core.ProjectAggregate;
using Template.Core.ProjectAggregate.Specifications;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedKernel.Interfaces;

namespace Template.Web.Pages.ProjectDetails;

public class IncompleteModel : PageModel
{
    private readonly IRepository<Project> _repository;

    [BindProperty(SupportsGet = true)] public Guid ProjectId { get; set; }

    public List<ToDoItem>? ToDoItems { get; set; }

    public IncompleteModel(IRepository<Project> repository)
    {
        _repository = repository;
    }

    public async Task OnGetAsync()
    {
        var projectSpec = new ProjectByIdWithItemsSpec(ProjectId);
        var project = await _repository.FirstOrDefaultAsync(projectSpec);
        if (project == null)
        {
            return;
        }

        var spec = new IncompleteItemsSpec();

        ToDoItems = spec.Evaluate(project.Items).ToList();
    }
}
