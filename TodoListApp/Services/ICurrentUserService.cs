namespace TodoListApp.Services;

public interface ICurrentUserService
{
    Task<Guid> GetUserIdAsync();
}