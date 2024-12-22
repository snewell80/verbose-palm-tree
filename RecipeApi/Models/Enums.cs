using System.Diagnostics.Metrics;

namespace RecipeApi.Models;

public class Enums
{
    public enum RecipeType
    {
        Breakfast = 1,
        Lunch = 2,
        Dinner = 3,
        Snacks = 4,
        Appetizer = 5,
        Side = 6
    }

    public enum Protein
    {
        None = 0,
        Beef = 1,
        Chicken = 2,
        Fish = 3,
        Plant = 4,
        Tofu = 5
    }

    public enum Measurement
    {
        Teaspoon = 1,
        Tablespoon = 2,
        Cup = 3,
        Ounce =4,
        Pound = 5
    }
}