using TodoListApp.Dtos;

namespace TodoListApp.Services;

public interface ITodoTaskService
{
    Task<List<TodoTaskDto>> GetForUserAsync(Guid userId, DateTime from, DateTime to);
    Task<TodoTaskDto?> GetByIdAsync(Guid userId, Guid taskId);
    Task<TodoTaskDto> CreateAsync(Guid userId, CreateTodoTaskDto dto);
    Task<bool> UpdateAsync(Guid userId, Guid taskId, UpdateTodoTaskDto dto);
    Task<bool> DeleteAsync(Guid userId, Guid taskId);
}