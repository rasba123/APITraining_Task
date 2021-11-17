using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentPortal.Model.Migrations
{
    public partial class initialstudentdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2021, 11, 17, 11, 33, 24, 904, DateTimeKind.Local).AddTicks(2405));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2021, 11, 16, 14, 26, 11, 43, DateTimeKind.Local).AddTicks(5724));
        }
    }
}
