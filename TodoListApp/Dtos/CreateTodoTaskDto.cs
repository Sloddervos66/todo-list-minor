namespace TodoListApp.Dtos;

public class CreateTodoTaskDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime From { get; set; } = DateTime.Now;
    public DateTime To { get; set; } = DateTime.Now;
}