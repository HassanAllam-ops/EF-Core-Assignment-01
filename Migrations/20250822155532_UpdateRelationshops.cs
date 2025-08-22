using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Assignment_01.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationshops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseInstructors_CourseInstructorCourseId_CourseInstructorInstractorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_CourseInstructors_CourseInstructorCourseId_CourseInstructorInstractorId",
                table: "Instructors");

            migrationBuilder.DropTable(
                name: "StudentStudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_CourseInstructorCourseId_CourseInstructorInstractorId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseInstructorCourseId_CourseInstructorInstractorId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseInstructorCourseId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "CourseInstructorInstractorId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "CourseInstructorCourseId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseInstructorInstractorId",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentCourses",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructors_InstractorId",
                table: "CourseInstructors",
                column: "InstractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Courses_CourseId",
                table: "CourseInstructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Instructors_InstractorId",
                table: "CourseInstructors",
                column: "InstractorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_StudentId",
                table: "StudentCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Courses_CourseId",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Instructors_InstractorId",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_StudentId",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructors_InstractorId",
                table: "CourseInstructors");

            migrationBuilder.AddColumn<int>(
                name: "CourseInstructorCourseId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseInstructorInstractorId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseInstructorCourseId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseInstructorInstractorId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentStudentCourse",
                columns: table => new
                {
                    HaveId = table.Column<int>(type: "int", nullable: false),
                    TakesStudentId = table.Column<int>(type: "int", nullable: false),
                    TakesCourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStudentCourse", x => new { x.HaveId, x.TakesStudentId, x.TakesCourseId });
                    table.ForeignKey(
                        name: "FK_StudentStudentCourse_StudentCourses_TakesStudentId_TakesCourseId",
                        columns: x => new { x.TakesStudentId, x.TakesCourseId },
                        principalTable: "StudentCourses",
                        principalColumns: new[] { "StudentId", "CourseId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentStudentCourse_Students_HaveId",
                        column: x => x.HaveId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CourseInstructorCourseId_CourseInstructorInstractorId",
                table: "Instructors",
                columns: new[] { "CourseInstructorCourseId", "CourseInstructorInstractorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseInstructorCourseId_CourseInstructorInstractorId",
                table: "Courses",
                columns: new[] { "CourseInstructorCourseId", "CourseInstructorInstractorId" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudentCourse_TakesStudentId_TakesCourseId",
                table: "StudentStudentCourse",
                columns: new[] { "TakesStudentId", "TakesCourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseInstructors_CourseInstructorCourseId_CourseInstructorInstractorId",
                table: "Courses",
                columns: new[] { "CourseInstructorCourseId", "CourseInstructorInstractorId" },
                principalTable: "CourseInstructors",
                principalColumns: new[] { "CourseId", "InstractorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_CourseInstructors_CourseInstructorCourseId_CourseInstructorInstractorId",
                table: "Instructors",
                columns: new[] { "CourseInstructorCourseId", "CourseInstructorInstractorId" },
                principalTable: "CourseInstructors",
                principalColumns: new[] { "CourseId", "InstractorId" });
        }
    }
}
