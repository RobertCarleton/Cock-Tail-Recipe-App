using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace CocktailRecipeApp
{
    public partial class MainWindow : Window
    {
        private CocktailDbContext _dbContext;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the database context
            _dbContext = new CocktailDbContext();

            // Load cocktails into the list
            LoadCocktails();
            MainFrame.Navigate(new HomePage());
        }

        private void LoadCocktails()
        {
            var cocktails = _dbContext.Cocktails.ToList();
            CocktailsListView.ItemsSource = cocktails;
        }

        private void NavigateToHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void NavigateToEditCocktail_Click(object sender, RoutedEventArgs e)
        {
            // Example cocktail passed for editing.
            var editCocktailPage = new EditCocktailPage(new Cocktail
            {
                CocktailName = "Martini",
                GlassType = CocktailGlassType.Martini,
                Ingredient = "Gin, Vermouth",
                Instructions = "Stir with ice and strain into a chilled glass."
            });
            MainFrame.Navigate(editCocktailPage);
        }

        private void NavigateToRateCocktail_Click(object sender, RoutedEventArgs e)
        {
            // Example cocktail passed for rating.
            var rateCocktailPage = new RateCocktailPage(new Cocktail
            {
                CocktailName = "Old Fashioned",
                Rating = 4
            });
            MainFrame.Navigate(rateCocktailPage);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchTextBox.Text;

            var filteredCocktails = _dbContext.Cocktails
                .Where(c => c.CocktailName.Contains(searchQuery) || c.Ingredient.Contains(searchQuery))
                .ToList();

            CocktailsListView.ItemsSource = filteredCocktails;
        }

        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {
            var randomCocktail = _dbContext.Cocktails.OrderBy(c => Guid.NewGuid()).FirstOrDefault();
            if (randomCocktail != null)
            {
                MessageBox.Show($"Cocktail of the Day:\n\n{randomCocktail.CocktailName}\n{randomCocktail.Ingredient}\n{randomCocktail.Instructions}");
            }
            else
            {
                MessageBox.Show("No cocktails available.");
            }
        }

        private void CocktailsListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Optionally handle selection logic if needed.
        }
    }
    public class StringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.IsNullOrWhiteSpace(value as string) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
