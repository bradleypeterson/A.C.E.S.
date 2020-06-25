using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class updatedsectionv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section");

            migrationBuilder.DropIndex(
                name: "IX_Section_CourseID",
                table: "Section");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Section",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Section",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
