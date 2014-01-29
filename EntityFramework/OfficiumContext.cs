using System.Data.Entity;
using officium.DataModels;

namespace officium.EntityFramework
{
    public class OfficiumContext:DbContext
    {
         public DbSet<Recipe> Recipes { get; set; }
    }
}