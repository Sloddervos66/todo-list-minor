using System.ComponentModel.DataAnnotations;

namespace TodoList.Components.Classes;

public sealed class Item
{
    public Guid Id { get; init; } = Guid.NewGuid();
    
    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; } = string.Empty;
    
    [DateNotInPast(ErrorMessage = "The date cannot be in the past or today.")]
    public DateTime When { get; set; } = DateTime.Today;
    
    public bool Completed { get; set; }
}