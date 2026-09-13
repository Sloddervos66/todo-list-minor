using TodoListApp.Data;
using TodoListApp.Dtos;

namespace TodoListApp.Extensions;

public static class TodoTaskExtensions
{
    public static TodoTaskDto ToDto(this TodoTask todoTask)
    {
        return new TodoTaskDto
        {
            Id = todoTask.Id,
            Title = todoTask.Title,
            Description = todoTask.Description,
            From = todoTask.From,
            To = todoTask.To,
            Completed = todoTask.Completed
        };
    }
}