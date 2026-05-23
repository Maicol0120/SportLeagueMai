using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsLeague.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class New_MatchLineup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_tournaments_TournamentId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_TournamentTeams_tournaments_TournamentId",
                table: "TournamentTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tournaments",
                table: "tournaments");

            migrationBuilder.RenameTable(
                name: "tournaments",
                newName: "Tournaments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournaments",
                table: "Tournaments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MatchLineups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    IsStarter = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchLineups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchLineups_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchLineups_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchLineups_MatchId_PlayerId",
                table: "MatchLineups",
                columns: new[] { "MatchId", "PlayerId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatchLineups_PlayerId",
                table: "MatchLineups",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentTeams_Tournaments_TournamentId",
                table: "TournamentTeams",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_TournamentTeams_Tournaments_TournamentId",
                table: "TournamentTeams");

            migrationBuilder.DropTable(
                name: "MatchLineups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournaments",
                table: "Tournaments");

            migrationBuilder.RenameTable(
                name: "Tournaments",
                newName: "tournaments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tournaments",
                table: "tournaments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_tournaments_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentTeams_tournaments_TournamentId",
                table: "TournamentTeams",
                column: "TournamentId",
                principalTable: "tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
