using static RecipeApi.Models.Enums;

namespace RecipeApi.Models;

public class Recipe
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public RecipeType Type { get; set; }
    public required Ingredient[] Ingredients { get; set; }
    public required Direction[] Directions { get; set; }
    public Protein Protein { get; set; }
    public int Servings { get; set; }
    public required List<string> Tags { get; set; } = [];
}
