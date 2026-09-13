using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeWhenFromTodoTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "due_date",
                table: "todo_tasks",
                newName: "to");

            migrationBuilder.AddColumn<DateTime>(
                name: "from",
                table: "todo_tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "from",
                table: "todo_tasks");

            migrationBuilder.RenameColumn(
                name: "to",
                table: "todo_tasks",
                newName: "due_date");
        }
    }
}
