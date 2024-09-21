using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class fix_database2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: 1,
                column: "ContentType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: 2,
                column: "ContentType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: 3,
                column: "ContentType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: 4,
                column: "ContentType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Resource",
                keyColumn: "ResourceId",
                keyValue: 1,
                column: "ResourceType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Resource",
                keyColumn: "ResourceId",
                keyValue: 2,
                column: "ResourceType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Resource",
                keyColumn: "ResourceId",
                keyValue: 3,
                column: "ResourceType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Resource",
                keyColumn: "ResourceId",
                keyValue: 4,
                column: "ResourceType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2024, 9, 21, 14, 11, 37, 698, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2024, 9, 21, 14, 11, 37, 698, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "RegisteredOn",
                value: new DateTime(2024, 9, 21, 14, 11, 37, 698, DateTimeKind.Local).AddTicks(8101));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: 1,
                column: "ContentType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: 2,
                column: "ContentType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: 3,
                column: "ContentType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: 4,
                column: "ContentType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Resource",
                keyColumn: "ResourceId",
                keyValue: 1,
                column: "ResourceType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Resource",
                keyColumn: "ResourceId",
                keyValue: 2,
                column: "ResourceType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Resource",
                keyColumn: "ResourceId",
                keyValue: 3,
                column: "ResourceType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Resource",
                keyColumn: "ResourceId",
                keyValue: 4,
                column: "ResourceType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2024, 9, 21, 14, 2, 26, 251, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2024, 9, 21, 14, 2, 26, 251, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "RegisteredOn",
                value: new DateTime(2024, 9, 21, 14, 2, 26, 251, DateTimeKind.Local).AddTicks(9858));
        }
    }
}
