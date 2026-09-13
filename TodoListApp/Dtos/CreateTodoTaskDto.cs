using System.ComponentModel.DataAnnotations;
using TodoListApp.Attributes;
using TodoListApp.Extensions;

namespace TodoListApp.Dtos;

[ValidTaskTimeRange]
public class CreateTodoTaskDto
{
    [Required(ErrorMessage = "Title is required.")]
    [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
    public string Title { get; set; } = string.Empty;
    
    [MaxLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
    public string Description { get; set; } = string.Empty;
    public DateTime From { get; set; } = DateTime.Now.ToQuarterHour();
    public DateTime To { get; set; } = DateTime.Now.ToQuarterHour();
}