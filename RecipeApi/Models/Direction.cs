using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace RecipeApi.Models;

public class Direction
{
    public int Id { get; set; }
    public int RecipeId { get; set; }
    public int StepNumber { get; set; }
    public required string Text { get; set; }
}