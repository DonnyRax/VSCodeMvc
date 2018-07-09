using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mvcmovie.Migrations
{
    public partial class MovieBoxOfficeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BoxOffice",
                table: "Movie",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropColumn(
                name: "BoxOffice",
                table: "Movie");
        }
    }
}
