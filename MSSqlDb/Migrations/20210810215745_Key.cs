using Microsoft.EntityFrameworkCore.Migrations;

namespace MSSqlDb.Migrations
{
    public partial class Key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Inschrijvings",
                table: "Inschrijvings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Inschrijvings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Inschrijvings",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inschrijvings",
                table: "Inschrijvings",
                column: "Id");
        }
    }
}
