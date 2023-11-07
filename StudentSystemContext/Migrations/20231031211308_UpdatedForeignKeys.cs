using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_StudentSystem.Data.Migrations
{
    public partial class UpdatedForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorseId",
                table: "Homeworks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CorseId",
                table: "Homeworks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
