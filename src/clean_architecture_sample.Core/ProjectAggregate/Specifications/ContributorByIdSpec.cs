using Ardalis.Specification;
using clean_architecture_sample.Core.ContributorAggregate;

namespace clean_architecture_sample.Core.ProjectAggregate.Specifications;

public class ContributorByIdSpec : Specification<Contributor>, ISingleResultSpecification
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
