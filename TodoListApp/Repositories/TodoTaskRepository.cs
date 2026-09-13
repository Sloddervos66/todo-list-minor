using Microsoft.EntityFrameworkCore;
using TodoListApp.Data;

namespace TodoListApp.Repositories;

public sealed class TodoTaskRepository(ApplicationDbContext db) : ITodoTaskRepository
{
    public async Task<List<TodoTask>> GetAllByUserIdAsync(Guid userId, DateTime from, DateTime to)
    {
        return await db.TodoTasks
            .AsNoTracking()
            .Where(t =>
                t.UserId == userId &&
                t.From < to &&
                t.To > from)
            .OrderBy(t => t.From)
            .ToListAsync();
    }

    public async Task<TodoTask?> GetByIdAsync(Guid userId, Guid taskId)
    {
        return await db.TodoTasks
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.UserId == userId && t.Id == taskId);
    }

    public async Task AddAsync(TodoTask todoTask)
    {
        await db.TodoTasks.AddAsync(todoTask);
        await db.SaveChangesAsync();
    }

    public async Task UpdateAsync(TodoTask todoTask)
    {
        db.TodoTasks.Update(todoTask);
        await db.SaveChangesAsync();
    }

    public async Task DeleteAsync(TodoTask todoTask)
    {
        db.TodoTasks.Remove(todoTask);
        await db.SaveChangesAsync();
    }
}