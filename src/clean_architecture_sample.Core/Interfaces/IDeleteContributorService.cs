using Ardalis.Result;

namespace clean_architecture_sample.Core.Interfaces;

public interface IDeleteContributorService
{
    public Task<Result> DeleteContributor(int contributorId);
}
