using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkTest.Data.Migrations
{
    /// <inheritdoc />
    public partial class teampractice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecretPractice",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecretPractice",
                table: "Teams");
        }
    }
}
