using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class EditTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentCourseCourseId",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseStudentId",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseCourseId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseStudentId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentCourseStudentId_StudentCourseCourseId",
                table: "Student",
                columns: new[] { "StudentCourseStudentId", "StudentCourseCourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_Course_StudentCourseStudentId_StudentCourseCourseId",
                table: "Course",
                columns: new[] { "StudentCourseStudentId", "StudentCourseCourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Course_StudentCourse_StudentCourseStudentId_StudentCourseCourseId",
                table: "Course",
                columns: new[] { "StudentCourseStudentId", "StudentCourseCourseId" },
                principalTable: "StudentCourse",
                principalColumns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentCourse_StudentCourseStudentId_StudentCourseCourseId",
                table: "Student",
                columns: new[] { "StudentCourseStudentId", "StudentCourseCourseId" },
                principalTable: "StudentCourse",
                principalColumns: new[] { "StudentId", "CourseId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_StudentCourse_StudentCourseStudentId_StudentCourseCourseId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentCourse_StudentCourseStudentId_StudentCourseCourseId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentCourseStudentId_StudentCourseCourseId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Course_StudentCourseStudentId_StudentCourseCourseId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "StudentCourseCourseId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentCourseStudentId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentCourseCourseId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "StudentCourseStudentId",
                table: "Course");
        }
    }
}
