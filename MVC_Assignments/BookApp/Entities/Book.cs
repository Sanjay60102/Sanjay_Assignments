using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Entities;

public partial class Book
{
    [Required(ErrorMessage = "The BookId field is required.")]
    public int BookId { get; set; }
    [Required(ErrorMessage = "The BookName field is required.")]
    public string BookName { get; set; } = null!;
    [Required(ErrorMessage = "The Price field is required.")]
    public int? Price { get; set; }
    [Required(ErrorMessage = "The Author field is required.")]
    public string? Author { get; set; }
    [Required(ErrorMessage = "The Language field is required.")]
    public string? Language { get; set; }

    public DateOnly ReleaseDate { get; set; }
}
