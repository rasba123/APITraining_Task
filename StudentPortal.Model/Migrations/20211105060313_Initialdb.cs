using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentPortal.Model.Migrations
{
    public partial class Initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Marks1",
                table: "Student",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Marks2",
                table: "Student",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Marks3",
                table: "Student",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2021, 11, 4, 23, 3, 13, 90, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "Marks1", "Marks2", "Marks3" },
                values: new object[] { 70.9f, 80f, 90.8f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marks1",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Marks2",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Marks3",
                table: "Student");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2021, 11, 4, 2, 58, 5, 485, DateTimeKind.Local).AddTicks(6564));
        }
    }
}
