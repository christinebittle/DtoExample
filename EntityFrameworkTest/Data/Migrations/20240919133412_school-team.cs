using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkTest.Data.Migrations
{
    /// <inheritdoc />
    public partial class schoolteam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SchoolId",
                table: "Teams",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Schools_SchoolId",
                table: "Teams",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Schools_SchoolId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SchoolId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Teams");
        }
    }
}
