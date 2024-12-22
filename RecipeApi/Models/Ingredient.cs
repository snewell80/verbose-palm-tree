using Microsoft.AspNetCore.Mvc;
using static RecipeApi.Models.Enums;
namespace RecipeApi.Models;

public class Ingredient
{
    public int Id { get; set; }
    public int RecipeId { get; set; }
    public decimal Amount { get; set; }
    public Measurement Measurement { get; set; }
    public required string Title { get; set; } 

    public Ingredient(decimal amount, Measurement measurement, string title)
    {
        Amount = amount;
        Measurement = measurement;
        Title = title;
    }
}