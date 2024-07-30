using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Lab1.Migrations
{
    /// <inheritdoc />
    public partial class rmImges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Students",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
