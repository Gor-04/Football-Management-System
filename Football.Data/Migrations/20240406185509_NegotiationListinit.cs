using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football.Data.Migrations
{
    /// <inheritdoc />
    public partial class NegotiationListinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NegotrationLists",
                columns: table => new
                {
                    NegotrationListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PreviousTeam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NewTeam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NegotrationLists", x => x.NegotrationListID);
                    table.ForeignKey(
                        name: "FK_NegotrationLists_PlayerLists_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "PlayerLists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NegotrationLists_PlayerID",
                table: "NegotrationLists",
                column: "PlayerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NegotrationLists");
        }
    }
}
