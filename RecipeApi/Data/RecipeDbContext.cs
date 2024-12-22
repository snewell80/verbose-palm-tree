using Microsoft.EntityFrameworkCore;
using RecipeApi.Models;

namespace RecipeApi.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
     {
     }
    public DbSet <Recipe> Recipes{ get; set; }
  }
}