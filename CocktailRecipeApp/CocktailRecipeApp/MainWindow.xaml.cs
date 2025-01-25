using System.Windows;
using CocktailRecipeApp.Pages;
namespace CocktailRecipeApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Load Home Page by default
            MainFrame.Navigate(new HomePage());
        }

        private void NavigateToHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void NavigateToCocktails_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CocktailsPage());
        }

        private void NavigateToAbout_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AboutUsPage());
        }
    }
}
