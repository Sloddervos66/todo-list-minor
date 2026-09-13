using TodoListApp.Dtos;

namespace TodoListApp.Classes;

public sealed record TaskLayout(TodoTaskDto Task, int Column, int ColumnCount);