using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pool.Data.Migrations
{
    public partial class onetomanyandmanytomany2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "swimmers");

            migrationBuilder.DropColumn(
                name: "ActivityName",
                table: "guides");

            migrationBuilder.CreateTable(
                name: "ActivitySwimmer",
                columns: table => new
                {
                    ActivitySwimmersId = table.Column<int>(type: "int", nullable: false),
                    SwimmerActivitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitySwimmer", x => new { x.ActivitySwimmersId, x.SwimmerActivitiesId });
                    table.ForeignKey(
                        name: "FK_ActivitySwimmer_activities_SwimmerActivitiesId",
                        column: x => x.SwimmerActivitiesId,
                        principalTable: "activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitySwimmer_swimmers_ActivitySwimmersId",
                        column: x => x.ActivitySwimmersId,
                        principalTable: "swimmers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_activities_GuideId",
                table: "activities",
                column: "GuideId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitySwimmer_SwimmerActivitiesId",
                table: "ActivitySwimmer",
                column: "SwimmerActivitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_activities_guides_GuideId",
                table: "activities",
                column: "GuideId",
                principalTable: "guides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_activities_guides_GuideId",
                table: "activities");

            migrationBuilder.DropTable(
                name: "ActivitySwimmer");

            migrationBuilder.DropIndex(
                name: "IX_activities_GuideId",
                table: "activities");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "swimmers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ActivityName",
                table: "guides",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
