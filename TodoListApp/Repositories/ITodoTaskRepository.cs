using TodoListApp.Data;

namespace TodoListApp.Repositories;

public interface ITodoTaskRepository
{
    Task<List<TodoTask>> GetAllByUserIdAsync(Guid userId, DateTime from, DateTime to);
    Task<TodoTask?> GetByIdAsync(Guid userId, Guid taskId);
    Task AddAsync(TodoTask todoTask);
    Task UpdateAsync(TodoTask todoTask);
    Task DeleteAsync(TodoTask todoTask);
}