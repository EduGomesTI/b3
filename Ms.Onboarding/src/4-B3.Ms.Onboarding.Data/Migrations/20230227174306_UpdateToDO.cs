using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace B3.Ms.Onboarding.Data.Migrations
{
    public partial class UpdateToDO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "ToDo",
                newName: "CreateDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "ConclusionDate",
                table: "ToDo",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConclusionDate",
                table: "ToDo");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "ToDo",
                newName: "Date");
        }
    }
}
