using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class stucour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Adresses_StudentId",
                table: "Adresses");

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Student_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_StudentId",
                table: "Adresses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentsId",
                table: "StudentCourses",
                column: "StudentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_StudentId",
                table: "Adresses");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_StudentId",
                table: "Adresses",
                column: "StudentId",
                unique: true);
        }
    }
}
