using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentPortal.Model.Migrations
{
    public partial class DBinitialStudentManagementtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Course");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Course",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Course",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
