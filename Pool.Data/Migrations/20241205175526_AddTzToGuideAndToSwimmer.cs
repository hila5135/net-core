using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pool.Data.Migrations
{
    public partial class AddTzToGuideAndToSwimmer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tz",
                table: "swimmers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tz",
                table: "guides",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tz",
                table: "swimmers");

            migrationBuilder.DropColumn(
                name: "Tz",
                table: "guides");
        }
    }
}
