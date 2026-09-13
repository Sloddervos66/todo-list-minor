using System.ComponentModel.DataAnnotations;

namespace TodoListApp.Data;

public class TodoTask
{
    public Guid Id { get; init; }
    
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;
    
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    
    public bool Completed { get; set; }
    
    public Guid UserId { get; init; }
    public ApplicationUser User { get; init; } = null!;
}