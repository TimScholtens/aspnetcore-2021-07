using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoProject.Migrations
{
    public partial class Players : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Penalties");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Penalties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Penalties_PlayerId",
                table: "Penalties",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Penalties_Players_PlayerId",
                table: "Penalties",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Penalties_Players_PlayerId",
                table: "Penalties");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Penalties_PlayerId",
                table: "Penalties");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Penalties");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Penalties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
