using Microsoft.AspNetCore.Mvc;

namespace Template.Web.Endpoints.ProjectEndpoints;

public class ListIncompleteRequest
{
    [FromRoute] public Guid ProjectId { get; set; }
    [FromQuery] public string? SearchString { get; set; }
}
