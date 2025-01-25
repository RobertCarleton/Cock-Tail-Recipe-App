using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CocktailRecipeApp.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 1,
                columns: new[] { "DateAdded", "ImagePath" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/PassionfruitMartini.jpg" });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 2,
                columns: new[] { "DateAdded", "ImagePath" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/OldFashioned.jpg" });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 3,
                columns: new[] { "DateAdded", "ImagePath" },
                values: new object[] { new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Cosmopolitan.jpg" });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 1,
                columns: new[] { "DateAdded", "ImagePath" },
                values: new object[] { new DateTime(2025, 1, 25, 17, 1, 27, 227, DateTimeKind.Local).AddTicks(6506), "Images/passion.jpg" });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 2,
                columns: new[] { "DateAdded", "ImagePath" },
                values: new object[] { new DateTime(2025, 1, 25, 17, 1, 27, 229, DateTimeKind.Local).AddTicks(7012), "Images/fash.jpg" });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 3,
                columns: new[] { "DateAdded", "ImagePath" },
                values: new object[] { new DateTime(2025, 1, 25, 17, 1, 27, 229, DateTimeKind.Local).AddTicks(7029), "Images/cosmo.jpg" });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2025, 1, 25, 17, 1, 27, 229, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "CocktailID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2025, 1, 25, 17, 1, 27, 229, DateTimeKind.Local).AddTicks(7062));
        }
    }
}
