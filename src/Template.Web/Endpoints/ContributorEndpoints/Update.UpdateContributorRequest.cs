﻿using System.ComponentModel.DataAnnotations;

namespace Template.Web.Endpoints.ContributorEndpoints;

public class UpdateContributorRequest
{
    public const string Route = "/Contributors";
    [Required] public int Id { get; set; }
    [Required] public string? Name { get; set; }
}
