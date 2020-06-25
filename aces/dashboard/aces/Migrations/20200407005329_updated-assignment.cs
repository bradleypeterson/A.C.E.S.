using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class updatedassignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Course_CourseID",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Submission_Student_StudentID",
                table: "Submission");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Submission",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Section",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Assignment",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Course_CourseID",
                table: "Assignment",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Submission_Student_StudentID",
                table: "Submission",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Course_CourseID",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Submission_Student_StudentID",
                table: "Submission");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Submission",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Section",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Assignment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Course_CourseID",
                table: "Assignment",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Course_CourseID",
                table: "Section",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Submission_Student_StudentID",
                table: "Submission",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
