using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentPortal.Model.Migrations
{
    public partial class DBinitialStudentManagementt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Standard_StandardId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_StandardId",
                table: "Teacher");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Standard",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Standard_TeacherId",
                table: "Standard",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Standard_Teacher_TeacherId",
                table: "Standard",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Standard_Teacher_TeacherId",
                table: "Standard");

            migrationBuilder.DropIndex(
                name: "IX_Standard_TeacherId",
                table: "Standard");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Standard");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_StandardId",
                table: "Teacher",
                column: "StandardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Standard_StandardId",
                table: "Teacher",
                column: "StandardId",
                principalTable: "Standard",
                principalColumn: "StandardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
