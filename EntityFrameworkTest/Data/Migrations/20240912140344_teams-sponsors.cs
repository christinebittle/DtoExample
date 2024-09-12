using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkTest.Data.Migrations
{
    /// <inheritdoc />
    public partial class teamssponsors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SponsorTeam",
                columns: table => new
                {
                    SponsorsSponsorId = table.Column<int>(type: "int", nullable: false),
                    TeamsTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorTeam", x => new { x.SponsorsSponsorId, x.TeamsTeamId });
                    table.ForeignKey(
                        name: "FK_SponsorTeam_Sponsors_SponsorsSponsorId",
                        column: x => x.SponsorsSponsorId,
                        principalTable: "Sponsors",
                        principalColumn: "SponsorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SponsorTeam_Teams_TeamsTeamId",
                        column: x => x.TeamsTeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SponsorTeam_TeamsTeamId",
                table: "SponsorTeam",
                column: "TeamsTeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SponsorTeam");
        }
    }
}
