using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace StudentPortal.Model.Migrations
{
    public partial class DBinitialStudentManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Student_StudentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_TeacherId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_StudentId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_TeacherId",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "StandardCode",
                table: "Standard",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentID",
                table: "Enrollment",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StandardCode",
                table: "Standard");

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentID",
                table: "Enrollment",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Course_StudentId",
                table: "Course",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherId",
                table: "Course",
                column: "TeacherId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Student_StudentId",
                table: "Course",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_TeacherId",
                table: "Course",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
