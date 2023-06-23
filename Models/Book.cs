using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Book
{
    public int Id { get; set; }

    [StringLength(100, MinimumLength = 1)]
    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; } = string.Empty;

    [RegularExpression(
        @"^[A-Z]+[a-zA-Z\s]*$",
        ErrorMessage = "Genre must start with an uppercase letter and contain only letters and spaces."
    )]
    [Required(ErrorMessage = "Genre is required.")]
    [StringLength(30)]
    public string Genre { get; set; } = string.Empty;

    [StringLength(100, MinimumLength = 1, ErrorMessage = "Author is required.")]
    public string Author { get; set; } = string.Empty;

    [StringLength(100, MinimumLength = 1, ErrorMessage = "Publisher is required.")]
    public string Publisher { get; set; } = string.Empty;

    [Required(ErrorMessage = "Publication date is required.")]
    public DateTime PublicationDate { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Pages must be a positive number.")]
    public int Pages { get; set; }
}
