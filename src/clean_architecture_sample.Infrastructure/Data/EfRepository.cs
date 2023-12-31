using Ardalis.Specification.EntityFrameworkCore;
using clean_architecture_sample.SharedKernel.Interfaces;

namespace clean_architecture_sample.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
