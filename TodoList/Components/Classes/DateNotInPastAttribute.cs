using System.ComponentModel.DataAnnotations;

namespace TodoList.Components.Classes;

public sealed class DateNotInPastAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime date && date <= DateTime.Today)
        {
            return new ValidationResult(
                ErrorMessage ?? "The date cannot be in the past or today.",
                [validationContext.MemberName!]);
        }
        
        return ValidationResult.Success;
    }
}