using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class addedoverridestanding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Submission_Assignment_AssignmentID",
                table: "Submission");

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentID",
                table: "Submission",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OverideStanding",
                table: "Assignment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Submission_Assignment_AssignmentID",
                table: "Submission",
                column: "AssignmentID",
                principalTable: "Assignment",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Submission_Assignment_AssignmentID",
                table: "Submission");

            migrationBuilder.DropColumn(
                name: "OverideStanding",
                table: "Assignment");

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentID",
                table: "Submission",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Submission_Assignment_AssignmentID",
                table: "Submission",
                column: "AssignmentID",
                principalTable: "Assignment",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
