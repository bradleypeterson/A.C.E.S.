using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class updatedsectionv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section");

            migrationBuilder.DropIndex(
                name: "IX_Section_CourseID",
                table: "Section");
        }
    }
}
