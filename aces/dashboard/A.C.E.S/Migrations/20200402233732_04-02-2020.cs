using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class _04022020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Section_SectionID",
                table: "Student");

            migrationBuilder.DropTable(
                name: "StudentAssignment");

            migrationBuilder.DropIndex(
                name: "IX_Student_SectionID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SectionID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Standing",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "Length",
                table: "Section",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "Section",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Section",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Section",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Assignment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: true),
                    AssignmentID = table.Column<int>(nullable: true),
                    Grade = table.Column<int>(nullable: false),
                    Standing = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Submission_Assignment_AssignmentID",
                        column: x => x.AssignmentID,
                        principalTable: "Assignment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submission_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Section_StudentID",
                table: "Section",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_AssignmentID",
                table: "Submission",
                column: "AssignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_StudentID",
                table: "Submission",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Student_StudentID",
                table: "Section",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Student_StudentID",
                table: "Section");

            migrationBuilder.DropTable(
                name: "Submission");

            migrationBuilder.DropIndex(
                name: "IX_Section_StudentID",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Assignment");

            migrationBuilder.AddColumn<int>(
                name: "SectionID",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Standing",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StudentAssignment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicStanding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAssignment", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_SectionID",
                table: "Student",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Section_SectionID",
                table: "Student",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
