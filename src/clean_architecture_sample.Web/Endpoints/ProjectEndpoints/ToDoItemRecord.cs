namespace clean_architecture_sample.Web.Endpoints.ProjectEndpoints;

public record ToDoItemRecord(int Id, string Title, string Description, bool IsDone);
