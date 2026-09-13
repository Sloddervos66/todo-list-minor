namespace TodoListApp.Dtos;

public sealed class TodoTaskDto
{
    public Guid Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public DateTime From { get; init; }
    public DateTime To { get; init; }
    public bool Completed { get; init; }
}