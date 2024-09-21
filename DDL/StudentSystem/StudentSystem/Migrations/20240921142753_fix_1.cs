using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class fix_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Course_CourseId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Student_StudentId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_Course_CourseId",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resource",
                table: "Resource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homework",
                table: "Homework");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "studentsCourses");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Resource",
                newName: "resources");

            migrationBuilder.RenameTable(
                name: "Homework",
                newName: "homeworks");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "courses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_CourseId",
                table: "studentsCourses",
                newName: "IX_studentsCourses_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Resource_CourseId",
                table: "resources",
                newName: "IX_resources_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Homework_StudentId",
                table: "homeworks",
                newName: "IX_homeworks_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Homework_CourseId",
                table: "homeworks",
                newName: "IX_homeworks_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentsCourses",
                table: "studentsCourses",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_resources",
                table: "resources",
                column: "ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_homeworks",
                table: "homeworks",
                column: "HomeworkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_homeworks_courses_CourseId",
                table: "homeworks",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_homeworks_students_StudentId",
                table: "homeworks",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_resources_courses_CourseId",
                table: "resources",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentsCourses_courses_CourseId",
                table: "studentsCourses",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentsCourses_students_StudentId",
                table: "studentsCourses",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_homeworks_courses_CourseId",
                table: "homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_homeworks_students_StudentId",
                table: "homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_resources_courses_CourseId",
                table: "resources");

            migrationBuilder.DropForeignKey(
                name: "FK_studentsCourses_courses_CourseId",
                table: "studentsCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_studentsCourses_students_StudentId",
                table: "studentsCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentsCourses",
                table: "studentsCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_resources",
                table: "resources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_homeworks",
                table: "homeworks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.RenameTable(
                name: "studentsCourses",
                newName: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "resources",
                newName: "Resource");

            migrationBuilder.RenameTable(
                name: "homeworks",
                newName: "Homework");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_studentsCourses_CourseId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_resources_CourseId",
                table: "Resource",
                newName: "IX_Resource_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_homeworks_StudentId",
                table: "Homework",
                newName: "IX_Homework_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_homeworks_CourseId",
                table: "Homework",
                newName: "IX_Homework_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resource",
                table: "Resource",
                column: "ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homework",
                table: "Homework",
                column: "HomeworkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Course_CourseId",
                table: "Homework",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Student_StudentId",
                table: "Homework",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_Course_CourseId",
                table: "Resource",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
