using System.ComponentModel.DataAnnotations.Schema;

namespace UnitTestingPractice.Models;

public class Book
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string Name { get; set; } = default!;
    public string Author { get; set; } = default!;
    public int Year { get; set; }
}