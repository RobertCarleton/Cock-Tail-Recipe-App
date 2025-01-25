using System.Windows;
using System.Windows.Controls;
using CocktailRecipeApp.Models;

namespace CocktailRecipeApp
{
    public partial class RateCocktailPage : Page
    {
        private Cocktail Cocktail;

        public RateCocktailPage(Cocktail cocktail)
        {
            InitializeComponent();
            Cocktail = cocktail;
            RatingSlider.Value = cocktail.Rating;
            RatingValueTextBlock.Text = cocktail.Rating.ToString();

            RatingSlider.ValueChanged += (s, e) =>
            {
                RatingValueTextBlock.Text = RatingSlider.Value.ToString("0");
            };
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Cocktail.Rating = (int)RatingSlider.Value;
            MessageBox.Show($"Cocktail rated {Cocktail.Rating}!");
            NavigationService.GoBack();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
