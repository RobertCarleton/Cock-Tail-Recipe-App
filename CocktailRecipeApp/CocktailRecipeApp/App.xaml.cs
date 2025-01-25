using System.Configuration;
using System.Data;
using System.Windows;
using CocktailRecipeApp.Models;
namespace CocktailRecipeApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly CocktailDbContext _context;

    public App()
    {
        InitializeComponent();
        _context = new CocktailDbContext();
        SeedData.Seed(_context);
    }
}

