using CocktailRecipeApp.Models;
using CocktailRecipeApp.Pages;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CocktailRecipeApp
{
    public partial class AddEditCocktailPage : Page
    {
        private readonly CocktailDbContext _context;
        private Cocktail _editingCocktail;

        public AddEditCocktailPage(Cocktail cocktail = null)
        {
            InitializeComponent();
            _context = new CocktailDbContext();

            // If a cocktail is passed, load its data for editing
            if (cocktail != null)
            {
                _editingCocktail = cocktail;
                LoadCocktailData();
            }
        }

        private void LoadCocktailData()
        {
            NameTextBox.Text = _editingCocktail.CocktailName;
            IngredientsTextBox.Text = _editingCocktail.Ingredient;
            InstructionsTextBox.Text = _editingCocktail.Instructions;
            DescriptionTextBox.Text = _editingCocktail.CocktailDescription;
            ImagePathTextBox.Text = _editingCocktail.ImagePath;
            FavouriteCheckBox.IsChecked = _editingCocktail.IsFavourite;
            //RatingTextBox.Text = _editingCocktail.Rating.ToString();

            var glassType = GlassTypeComboBox.Items
                .Cast<ComboBoxItem>()
                .FirstOrDefault(item => item.Content.ToString() == _editingCocktail.GlassType.ToString());
            if (glassType != null)
                GlassTypeComboBox.SelectedItem = glassType;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(IngredientsTextBox.Text) ||
                    string.IsNullOrWhiteSpace(InstructionsTextBox.Text) ||
                    string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
                {
                    MessageBox.Show("All fields except 'Favourite' are required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // If editing an existing cocktail, update its properties
                if (_editingCocktail != null)
                {
                    _editingCocktail.CocktailName = NameTextBox.Text;
                    _editingCocktail.GlassType = (CocktailGlassType)Enum.Parse(typeof(CocktailGlassType), ((ComboBoxItem)GlassTypeComboBox.SelectedItem).Content.ToString());
                    _editingCocktail.Ingredient = IngredientsTextBox.Text;
                    _editingCocktail.Instructions = InstructionsTextBox.Text;
                    _editingCocktail.CocktailDescription = DescriptionTextBox.Text;
                    _editingCocktail.ImagePath = ImagePathTextBox.Text;
                    _editingCocktail.IsFavourite = FavouriteCheckBox.IsChecked ?? false;
                    //_editingCocktail.Rating = int.Parse(RatingTextBox.Text);
                }
                else
                {
                    // Add a new cocktail
                    var newCocktail = new Cocktail
                    {
                        CocktailName = NameTextBox.Text,
                        GlassType = (CocktailGlassType)Enum.Parse(typeof(CocktailGlassType), ((ComboBoxItem)GlassTypeComboBox.SelectedItem).Content.ToString()),
                        Ingredient = IngredientsTextBox.Text,
                        Instructions = InstructionsTextBox.Text,
                        CocktailDescription = DescriptionTextBox.Text,
                        ImagePath = ImagePathTextBox.Text,
                        IsFavourite = FavouriteCheckBox.IsChecked ?? false,
                        //Rating = int.Parse(RatingTextBox.Text),
                        DateAdded = DateTime.Now
                    };
                    _context.Cocktails.Add(newCocktail);
                }

                _context.SaveChanges();
                MessageBox.Show("Cocktail saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                var destinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                if (!Directory.Exists(destinationFolder))
                    Directory.CreateDirectory(destinationFolder);

                var destinationPath = Path.Combine(destinationFolder, Path.GetFileName(openFileDialog.FileName));
                File.Copy(openFileDialog.FileName, destinationPath, true);

                ImagePathTextBox.Text = destinationPath;
            }
        }
    }
}
