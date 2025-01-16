using System.Windows;
using System.Windows.Controls;

namespace CocktailRecipeApp
{
    public partial class EditCocktailPage : Page
    {
        private Cocktail Cocktail;

        public EditCocktailPage(Cocktail cocktail)
        {
            InitializeComponent();
            Cocktail = cocktail;
            LoadCocktailDetails();
        }

        private void LoadCocktailDetails()
        {
            CocktailNameTextBox.Text = Cocktail.CocktailName;
            GlassTypeComboBox.SelectedItem = Cocktail.GlassType.ToString();
            IngredientsTextBox.Text = Cocktail.Ingredient;
            InstructionsTextBox.Text = Cocktail.Instructions;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Cocktail.CocktailName = CocktailNameTextBox.Text;
            Cocktail.GlassType = (CocktailGlassType)GlassTypeComboBox.SelectedIndex;
            Cocktail.Ingredient = IngredientsTextBox.Text;
            Cocktail.Instructions = InstructionsTextBox.Text;

            MessageBox.Show("Cocktail details saved!");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
