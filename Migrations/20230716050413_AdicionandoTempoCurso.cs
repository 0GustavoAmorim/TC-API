using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TC_API.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTempoCurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Duracao",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<bool>(
                name: "Finalizada",
                table: "Aulas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Tempo",
                table: "Aulas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "URLaula",
                table: "Aulas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finalizada",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "Tempo",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "URLaula",
                table: "Aulas");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duracao",
                table: "Cursos",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
