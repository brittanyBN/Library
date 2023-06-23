﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table =>
                    new
                    {
                        Id = table
                            .Column<int>(type: "INTEGER", nullable: false)
                            .Annotation("Sqlite:Autoincrement", true),
                        Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                        Genre = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                        Author = table.Column<string>(
                            type: "TEXT",
                            maxLength: 100,
                            nullable: false
                        ),
                        Publisher = table.Column<string>(
                            type: "TEXT",
                            maxLength: 100,
                            nullable: false
                        ),
                        PublicationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                        Pages = table.Column<int>(type: "INTEGER", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Book");
        }
    }
}
