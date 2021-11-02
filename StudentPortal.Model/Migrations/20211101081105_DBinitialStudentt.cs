using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentPortal.Model.Migrations
{
    public partial class DBinitialStudentt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Enrollment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_TeacherId",
                table: "Enrollment",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Teacher_TeacherId",
                table: "Enrollment",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Teacher_TeacherId",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_TeacherId",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Enrollment");
        }
    }
}
