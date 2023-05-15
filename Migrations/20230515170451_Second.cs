using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HockeyManager.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Playerss",
                table: "Playerss");

            migrationBuilder.RenameTable(
                name: "Playerss",
                newName: "Player");

            migrationBuilder.RenameColumn(
                name: "Possition",
                table: "Player",
                newName: "Position");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlayerId",
                table: "Player",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.RenameTable(
                name: "Player",
                newName: "Playerss");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Playerss",
                newName: "Possition");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "Playerss",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Playerss",
                table: "Playerss",
                column: "PlayerId");
        }
    }
}
