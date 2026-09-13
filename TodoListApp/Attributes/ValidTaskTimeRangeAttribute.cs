using System.ComponentModel.DataAnnotations;
using TodoListApp.Dtos;

namespace TodoListApp.Attributes;

public sealed class ValidTaskTimeRangeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return value switch
        {
            CreateTodoTaskDto createTask => Validate(createTask.From, createTask.To),
            UpdateTodoTaskDto updateTask => Validate(updateTask.From, updateTask.To),
            _ => ValidationResult.Success
        };
    }

    private static ValidationResult? Validate(DateTime from, DateTime to)
    {
        return to > from
            ? ValidationResult.Success
            : new ValidationResult("The end time must be after the start time.", ["To"]);
    }
}