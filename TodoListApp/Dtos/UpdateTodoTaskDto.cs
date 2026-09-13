namespace TodoListApp.Dtos;

public class UpdateTodoTaskDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public bool Completed { get; set; }
}