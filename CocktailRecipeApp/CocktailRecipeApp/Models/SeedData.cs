using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailRecipeApp.Models
{
    public class SeedData
    {
        public static void Seed(CocktailDbContext _context)
        {
            _context.Database.EnsureCreated();
            if (!_context.Cocktails.Any())
            {
                _context.AddRange(new List<Cocktail>()
            {
                new Cocktail
                {
                    CocktailName = "Passionfruit Martini",
                    GlassType = CocktailGlassType.Martini,
                    CocktailDescription = "A fruity and tropical cocktail made with passionfruit and vanilla vodka.",
                    Ingredient = "2 oz Vanilla Vodka, 1 oz Passionfruit Puree, 1 oz Lime Juice, 1 oz Simple Syrup, Prosecco to serve",
                    Instructions = "Shake all ingredients except prosecco with ice. Strain into a martini glass and top with prosecco.",
                    ImagePath = "CocktailRecipeApp;component/images/passion.jpeg",
                    DateAdded = new DateTime(2025, 1, 1),
                    IsFavourite = false,
                    Rating = 5
                },
                new Cocktail
                {
                    CocktailName = "Old Fashioned",
                    GlassType = CocktailGlassType.Rocks,
                    CocktailDescription = "A classic whiskey cocktail made with sugar, bitters, and citrus peel.",
                    Ingredient = "2 oz Bourbon or Rye Whiskey, 1 Sugar Cube, 2 Dashes Angostura Bitters, Orange Peel",
                    Instructions = "Muddle sugar cube and bitters in a glass. Add whiskey and ice, stir well. Garnish with orange peel.",
                    ImagePath = "CocktailRecipeApp;component/images/fash.jpg",
                    DateAdded = new DateTime(2025, 1, 2),
                    IsFavourite = false,
                    Rating = 4
                },
                new Cocktail
                {
                    CocktailName = "Cosmopolitan",
                    GlassType = CocktailGlassType.Martini,
                    CocktailDescription = "A stylish and tart cocktail with vodka, cranberry, and lime.",
                    Ingredient = "1.5 oz Citrus Vodka, 1 oz Cranberry Juice, 0.5 oz Lime Juice, 0.5 oz Triple Sec",
                    Instructions = "Shake all ingredients with ice and strain into a chilled martini glass. Garnish with lime wedge.",
                    ImagePath = "CocktailRecipeApp;component/images/cosmo.jpg",
                    DateAdded = new DateTime(2025, 1, 3),
                    IsFavourite = true,
                    Rating = 5
                },
                new Cocktail
                {
                    CocktailName = "Mojito",
                    GlassType = CocktailGlassType.Highball,
                    CocktailDescription = "A refreshing cocktail with mint, lime, sugar, and rum.",
                    Ingredient = "2 oz White Rum, 1/2 oz Lime Juice, 1/2 oz Sugar Syrup, Mint Leaves, Soda Water",
                    Instructions = "Muddle mint and sugar, add lime juice, rum, and soda water. Garnish with lime wedge",
                    ImagePath = "CocktailRecipeApp;component/images/mojito.png",
                    DateAdded = new DateTime(2025, 1, 15),
                    IsFavourite = false,
                    Rating = 5
                },
                new Cocktail
                {
                    CocktailName = "Margarita",
                    GlassType = CocktailGlassType.Coupe,
                    CocktailDescription = "A classic tequila-based cocktail with lime and Cointreau.",
                    Ingredient = "2 oz Tequila, 1 oz Lime Juice, 1 oz Cointreau, Salt",
                    Instructions = "Shake ingredients with ice and serve in a salted rim glass. Garnish with lime wedge",
                    ImagePath = "CocktailRecipeApp;component/images/margarita.jpg",
                    DateAdded = new DateTime(2025, 1, 20),
                    IsFavourite = true,
                    Rating = 4
                }
            }
            );
                _context.SaveChanges();
            }

        }
    }
}
