﻿using FastEndpoints;
using Ardalis.Result;
using clean_architecture_sample.Core.Interfaces;

namespace clean_architecture_sample.Web.Endpoints.ContributorEndpoints;

public class Delete : Endpoint<DeleteContributorRequest>
{

  private readonly IDeleteContributorService _deleteContributorService;

  public Delete(IDeleteContributorService service)
  {
    _deleteContributorService = service;
  }

  public override void Configure()
  {
    Delete(DeleteContributorRequest.Route);
    AllowAnonymous();
    Options(x => x
      .WithTags("ContributorEndpoints"));
  }
  public override async Task HandleAsync(
    DeleteContributorRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _deleteContributorService.DeleteContributor(request.ContributorId);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    await SendNoContentAsync(cancellationToken);
  }
}
