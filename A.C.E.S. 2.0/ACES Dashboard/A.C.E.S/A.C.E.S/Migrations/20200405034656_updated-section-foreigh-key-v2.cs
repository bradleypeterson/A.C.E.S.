using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class updatedsectionforeighkeyv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Section",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Section",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
