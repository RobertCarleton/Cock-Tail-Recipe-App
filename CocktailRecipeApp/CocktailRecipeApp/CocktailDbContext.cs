using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailRecipeApp
{
    public class CocktailDbContext : DbContext
    {
        //public CocktailDbContext(string databaseName) : base(databaseName)
        public CocktailDbContext()
        { }
        public DbSet<Cocktail> Cocktails { get; set; }

    }
}
