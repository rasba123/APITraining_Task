using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentPortal.Model.Migrations
{
    public partial class dbinitialsystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseName", "Location" },
                values: new object[] { 1, "OOP", "Campus" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "StandardId", "StudentName", "StudentPhone" },
                values: new object[] { 1, 1, "Rasba", "0123456" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherId", "StandardId", "TeacherName", "TeacherType" },
                values: new object[] { 1, 1, "XYZ", "Sci" });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "Date", "EnrollmentID", "TeacherId" },
                values: new object[] { 1, 1, new DateTime(2021, 11, 4, 2, 58, 5, 485, DateTimeKind.Local).AddTicks(6564), 1, 1 });

            migrationBuilder.InsertData(
                table: "Standard",
                columns: new[] { "StandardId", "StandardCode", "StandardDesc", "StandardName", "StudentId", "TeacherId" },
                values: new object[] { 1, 1, "abc", "standard", 1, 1 });

            migrationBuilder.InsertData(
                table: "StudentAddress",
                columns: new[] { "StandardId", "City", "State", "StudentAddress1", "StudentAddress2", "StudentId" },
                values: new object[] { 1, "Karachi", "", "Pechs", "block 6", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Standard",
                keyColumn: "StandardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentAddress",
                keyColumn: "StandardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherId",
                keyValue: 1);
        }
    }
}
