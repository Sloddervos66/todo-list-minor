using TodoListApp.Data;
using TodoListApp.Dtos;
using TodoListApp.Extensions;
using TodoListApp.Repositories;

namespace TodoListApp.Services;

public sealed class TodoTaskService(ITodoTaskRepository repository, ICurrentUserService currentUser) : ITodoTaskService
{
    public async Task<List<TodoTaskDto>> GetForUserAsync(DateTime from, DateTime to)
    {
        var userId = await currentUser.GetUserIdAsync();
        var tasks = await repository.GetAllByUserIdAsync(userId, from, to);
        
        return tasks.Select(TodoTaskExtensions.ToDto).ToList();
    }

    public async Task<TodoTaskDto?> GetByIdAsync(Guid taskId)
    {
        var userId = await currentUser.GetUserIdAsync();
        var task = await repository.GetByIdAsync(userId, taskId);
        
        return task?.ToDto();
    }

    public async Task<TodoTaskDto> CreateAsync(CreateTodoTaskDto dto)
    {
        if (dto.To <= dto.From)
            throw new ArgumentException("Task end must be after task start.");
        
        var userId = await currentUser.GetUserIdAsync();
        var task = new TodoTask
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            Title = dto.Title,
            From = dto.From,
            To = dto.To,
            Completed = false
        };
        await repository.AddAsync(task);
        
        return task.ToDto();
    }

    public async Task<bool> UpdateAsync(Guid taskId, UpdateTodoTaskDto dto)
    {
        if (dto.To <= dto.From)
            throw new ArgumentException("Task end must be after task start.");
        
        var userId = await currentUser.GetUserIdAsync();
        var task = await repository.GetByIdAsync(userId, taskId);
        if (task is null)
            return false;

        task.Title = dto.Title;
        task.From = dto.From;
        task.To = dto.To;
        task.Completed = dto.Completed;
        
        await repository.UpdateAsync(task);

        return true;
    }

    public async Task<bool> DeleteAsync(Guid taskId)
    {
        var userId = await currentUser.GetUserIdAsync();
        var task = await repository.GetByIdAsync(userId, taskId);
        if (task is null)
            return false;
        
        await repository.DeleteAsync(task);
        return true;
    }
}