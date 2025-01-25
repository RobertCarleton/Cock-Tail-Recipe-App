using System;
using System.Linq;
using System.Windows.Controls;
using CocktailRecipeApp;
using CocktailRecipeApp.Models;

namespace CocktailRecipeApp
{
    public partial class HomePage : Page
    {
        private CocktailDbContext _dbContext;

        public HomePage()
        {
            InitializeComponent();
            _dbContext = new CocktailDbContext();
            LoadRandomCocktail();
        }

        // This method loads a random cocktail and displays its details
        private void LoadRandomCocktail()
        {
            var randomCocktail = _dbContext.Cocktails
                                           .OrderBy(c => Guid.NewGuid())  // Randomize order
                                           .FirstOrDefault();  // Select the first cocktail (randomized)

            if (randomCocktail != null)
            {
                // Set the image and text to the random cocktail
                CocktailName.Text = randomCocktail.CocktailName;
                CocktailDescription.Text = randomCocktail.CocktailDescription;

                // Handle image
                if (!string.IsNullOrEmpty(randomCocktail.ImagePath))
                {
                    CocktailImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(randomCocktail.ImagePath, UriKind.RelativeOrAbsolute));
                }
                else
                {
                    CocktailImage.Source = null;  // No image path
                }
            }
            else
            {
                // If no cocktail found, display a default message
                CocktailName.Text = "No Cocktail Available";
                CocktailDescription.Text = "Please add cocktails to the database.";
            }
        }
    }
}
