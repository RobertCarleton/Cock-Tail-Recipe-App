using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using CocktailRecipeApp.Converters;
using CocktailRecipeApp.Models;

namespace CocktailRecipeApp
{
    public partial class HomePage : Page
    {
        private CocktailDbContext _dbContext;
        private PathToUriConverter _imageConverter;

        public HomePage()
        {
            InitializeComponent();
            _dbContext = new CocktailDbContext();
            _imageConverter = new PathToUriConverter();
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
                CocktailDescription.TextAlignment = TextAlignment.Center;

                // Handle image using the PathToUriConverter
                if (!string.IsNullOrEmpty(randomCocktail.ImagePath))
                {
                    CocktailImage.Source = _imageConverter.Convert(randomCocktail.ImagePath,
                                                                   typeof(System.Windows.Media.ImageSource),
                                                                   null,
                                                                   System.Globalization.CultureInfo.CurrentCulture)
                                                                   as System.Windows.Media.ImageSource;
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
