using System.ComponentModel.DataAnnotations;

namespace TodoListApp.Data;

public class TodoTask
{
    public Guid Id { get; init; }
    
    [MaxLength(100)]
    public string Title { get; init; } = string.Empty;

    [MaxLength(500)]
    public string Description { get; init; } = string.Empty;
    
    public DateTime DueDate { get; init; }
    public bool Completed { get; init; }
    
    public Guid UserId { get; init; }
    public ApplicationUser User { get; init; } = null!;
}