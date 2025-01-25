using CocktailRecipeApp.Models;
using System.Windows;
using System.Windows.Controls;

namespace CocktailRecipeApp.Pages
{
    public partial class CocktailsPage : Page
    {
        private readonly CocktailDbContext _dbContext;

        public CocktailsPage()
        {
            InitializeComponent();
            _dbContext = new CocktailDbContext();
            LoadCocktails();
        }

        // Method to load all cocktails
        private void LoadCocktails()
        {
            try
            {
                var cocktails = _dbContext.Cocktails.ToList();
                CocktailsListView.ItemsSource = cocktails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cocktails: {ex.Message}");
            }
        }

        // Method to handle Search TextBox text changes
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = SearchTextBox.Text.ToLower();
            var filteredCocktails = _dbContext.Cocktails
                                              .Where(c => c.CocktailName.ToLower().Contains(searchTerm) ||
                                                          c.Ingredient.ToLower().Contains(searchTerm))
                                              .ToList();
            CocktailsListView.ItemsSource = filteredCocktails;
        }

        // Method to handle the "Search" button click
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchTextBox.Text.ToLower();
            var filteredCocktails = _dbContext.Cocktails
                                              .Where(c => c.CocktailName.ToLower().Contains(searchTerm) ||
                                                          c.Ingredient.ToLower().Contains(searchTerm))
                                              .ToList();
            CocktailsListView.ItemsSource = filteredCocktails;
        }

        // Handling the TextBox focus to hide the placeholder
        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text.Length > 0)
            {
                SearchPlaceholder.Visibility = Visibility.Collapsed;
            }
        }

        // Handling the TextBox lost focus to show the placeholder if empty
        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                SearchPlaceholder.Visibility = Visibility.Visible;
            }
        }

        // Selection changed event for the ListView
        private void CocktailsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCocktail = (Cocktail)CocktailsListView.SelectedItem;
            if (selectedCocktail != null)
            {
                // Enable the action buttons when a cocktail is selected
                EditButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
                RateButton.IsEnabled = true;
            }
            else
            {
                // Disable the action buttons when no cocktail is selected
                EditButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
                RateButton.IsEnabled = false;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Add/Edit Cocktail page
            NavigationService.Navigate(new AddEditCocktailPage());
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Edit Cocktail page with selected item
            if (CocktailsListView.SelectedItem is Cocktail selectedCocktail)
            {
                NavigationService.Navigate(new AddEditCocktailPage(selectedCocktail));
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle deletion logic for the selected cocktail
            if (CocktailsListView.SelectedItem is Cocktail selectedCocktail)
            {
                _dbContext.Cocktails.Remove(selectedCocktail);
                _dbContext.SaveChanges();
                LoadCocktails();
                MessageBox.Show("Cocktail deleted successfully!");
            }
        }

        private void RateButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Rate Cocktail page with selected item
            if (CocktailsListView.SelectedItem is Cocktail selectedCocktail)
            {
                NavigationService.Navigate(new RateCocktailPage(selectedCocktail));
            }
        }
    }
}
