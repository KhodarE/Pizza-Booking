using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GourmetPizza.Migrations
{
    public partial class PizzaShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    PizzaID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PizzaName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.PizzaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizza");
        }
    }
}
