using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class fixedspelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverideStanding",
                table: "Assignment");

            migrationBuilder.AddColumn<int>(
                name: "OverrideStanding",
                table: "Assignment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverrideStanding",
                table: "Assignment");

            migrationBuilder.AddColumn<int>(
                name: "OverideStanding",
                table: "Assignment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
