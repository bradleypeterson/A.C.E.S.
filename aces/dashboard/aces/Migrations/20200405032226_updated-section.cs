using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class updatedsection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Section",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Section_CourseID",
                table: "Section",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section");

            migrationBuilder.DropIndex(
                name: "IX_Section_CourseID",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Section");
        }
    }
}
