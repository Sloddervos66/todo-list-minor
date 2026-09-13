using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TodoListApp.Data;

public class TodoTask
{
    public Guid Id { get; set; }
    
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;
    
    public DateTime DueDate { get; set; }
    public bool Completed { get; set; }
    
    public Guid UserId { get; set; }
    public IdentityUser User { get; set; } = null!;
}