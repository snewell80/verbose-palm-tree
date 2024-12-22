using System.Text.Json.Serialization;
using RecipeApi.Data;
using Microsoft.EntityFrameworkCore;
using RecipeApi.Models;
using static RecipeApi.Models.Enums;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(static options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySQL("Corridor");
});

var app = builder.Build();

// var sampleRecipe = new Todo[]
// {
//     new(1, "Walk the dog"),
//     new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
//     new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
//     new(4, "Clean the bathroom"),
//     new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
// };

// var todosApi = app.MapGroup("/todos");
// todosApi.MapGet("/", () => sampleTodos);
// todosApi.MapGet("/{id}", (int id) =>
//     sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
//         ? Results.Ok(todo)
//         : Results.NotFound());

var sampleRecipe = new Recipe[]
    {
        new Recipe
        {
            Id = 1,
            Title = "Pancakes",
            Type = RecipeType.Breakfast,
            Ingredients =
            [
                new Ingredient(1m, Measurement.Cup, "flour") { Title = "Flour" },
                new Ingredient(1m, Measurement.Cup, "milk") { Title = "Milk" }
            ],
            Directions =
            [
                new Direction { StepNumber = 1, Text = "Mix flour, milk, and egg in a bowl" },
                new Direction { StepNumber = 2, Text = "Pour 1/4 cup of batter onto a hot griddle"},
                new Direction { StepNumber = 3, Text = "Cook until bubbles form on the surface" },
                new Direction { StepNumber = 4, Text = "Flip and cook until golden brown"}
            ],
            Protein = Protein.None,
            Servings = 4,
            Tags = ["easy", "breakfast"]
        }
    };

var recipesApi = app.MapGroup("/recipes");
recipesApi.MapGet("/", () => sampleRecipe);

app.Run();

public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

[JsonSerializable(typeof(Recipe[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}