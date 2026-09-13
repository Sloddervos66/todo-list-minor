using TodoListApp.Dtos;

namespace TodoListApp.Services;

public interface ITodoTaskService
{
    Task<List<TodoTaskDto>> GetForUserAsync(DateTime from, DateTime to);
    Task<TodoTaskDto?> GetByIdAsync(Guid taskId);
    Task<TodoTaskDto> CreateAsync(CreateTodoTaskDto dto);
    Task<bool> UpdateAsync(Guid taskId, UpdateTodoTaskDto dto);
    Task<bool> DeleteAsync(Guid taskId);
}