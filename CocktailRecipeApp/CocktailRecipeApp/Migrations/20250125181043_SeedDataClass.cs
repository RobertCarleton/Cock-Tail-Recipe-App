using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CocktailRecipeApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "CocktailID", "CocktailDescription", "CocktailName", "DateAdded", "GlassType", "ImagePath", "Ingredient", "Instructions", "IsFavourite", "Rating" },
                values: new object[,]
                {
                    { 1, "A fruity and tropical cocktail made with passionfruit and vanilla vodka.", "Passionfruit Martini", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Images/PassionfruitMartini.jpg", "2 oz Vanilla Vodka, 1 oz Passionfruit Puree, 1 oz Lime Juice, 1 oz Simple Syrup, Prosecco to serve", "Shake all ingredients except prosecco with ice. Strain into a martini glass and top with prosecco.", false, 5 },
                    { 2, "A classic whiskey cocktail made with sugar, bitters, and citrus peel.", "Old Fashioned", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Images/OldFashioned.jpg", "2 oz Bourbon or Rye Whiskey, 1 Sugar Cube, 2 Dashes Angostura Bitters, Orange Peel", "Muddle sugar cube and bitters in a glass. Add whiskey and ice, stir well. Garnish with orange peel.", false, 4 },
                    { 3, "A stylish and tart cocktail with vodka, cranberry, and lime.", "Cosmopolitan", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Images/Cosmopolitan.jpg", "1.5 oz Citrus Vodka, 1 oz Cranberry Juice, 0.5 oz Lime Juice, 0.5 oz Triple Sec", "Shake all ingredients with ice and strain into a chilled martini glass. Garnish with lime wedge.", true, 5 },
                    { 4, "A refreshing cocktail with mint, lime, sugar, and rum.", "Mojito", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Images/mojito.png", "Mint, Lime, Sugar, Rum, Soda Water", "Muddle mint and sugar, add lime juice, rum, and soda water.", false, 5 },
                    { 5, "A classic tequila-based cocktail with lime and Cointreau.", "Margarita", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Images/margarita.jpg", "Tequila, Lime Juice, Cointreau, Salt", "Shake ingredients with ice and serve in a salted rim glass.", true, 4 }
                });
        }
    }
}
