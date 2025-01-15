using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CocktailRecipeApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cocktails",
                columns: table => new
                {
                    CocktailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CocktailName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GlassType = table.Column<int>(type: "int", nullable: false),
                    CocktailDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ingredient = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    IsFavourite = table.Column<bool>(type: "bit", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocktails", x => x.CocktailID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cocktails");
        }
    }
}
