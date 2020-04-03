using Microsoft.EntityFrameworkCore.Migrations;

namespace A.C.E.S.Migrations
{
    public partial class _04022020550 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SectionStudent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionStudent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SectionStudent_Section_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Section",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionStudent_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionStudent_SectionID",
                table: "SectionStudent",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionStudent_StudentID",
                table: "SectionStudent",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionStudent");
        }
    }
}
