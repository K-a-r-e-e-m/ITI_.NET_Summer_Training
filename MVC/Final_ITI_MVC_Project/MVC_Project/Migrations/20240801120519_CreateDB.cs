using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_DeptId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_DeptId",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Trainees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Trainees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_DeptId",
                table: "Trainees",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_DeptId",
                table: "Trainees",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "DeptId");
        }
    }
}
