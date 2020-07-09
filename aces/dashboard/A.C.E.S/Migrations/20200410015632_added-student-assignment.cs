using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class addedstudentassignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageStanding",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "OverrideStanding",
                table: "Assignment");

            migrationBuilder.CreateTable(
                name: "StudentAssignment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    AssignmentID = table.Column<int>(nullable: false),
                    AverageStanding = table.Column<int>(nullable: false),
                    OverrideStanding = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAssignment", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAssignment");

            migrationBuilder.AddColumn<int>(
                name: "AverageStanding",
                table: "Assignment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OverrideStanding",
                table: "Assignment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
