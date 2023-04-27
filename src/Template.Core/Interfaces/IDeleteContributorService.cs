using Ardalis.Result;

namespace Template.Core.Interfaces;

public interface IDeleteContributorService
{
    public Task<Result> DeleteContributor(Guid contributorId);
}
