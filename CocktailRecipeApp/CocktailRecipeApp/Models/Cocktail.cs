using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CocktailRecipeApp.Models
{
    public enum CocktailGlassType
    {
        Martini,
        Highball,
        Coupe,
        Rocks,
        Gin,
        Lowball
    }
    public class Cocktail
    {
        public int CocktailID { get; set; }
        public string CocktailName { get; set; }
        public CocktailGlassType GlassType { get; set; }
        public string CocktailDescription { get; set; }
        public string Ingredient { get; set; }
        public string Instructions { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFavourite { get; set; }
        public int Rating { get; set; }
    }
}
