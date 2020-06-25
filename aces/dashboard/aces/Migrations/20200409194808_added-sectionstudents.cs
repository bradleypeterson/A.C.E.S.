using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class addedsectionstudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Student_StudentID",
                table: "Section");

            migrationBuilder.DropIndex(
                name: "IX_Section_StudentID",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Section");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Section",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Section_StudentID",
                table: "Section",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Student_StudentID",
                table: "Section",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
