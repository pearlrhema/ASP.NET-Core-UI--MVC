using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System;


namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

// set the display name for the ReleaseDate property to "Release Date" and specify that it should be treated as a date (without time) in the user interface.
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    // specify that the Price property should be stored in the database as a decimal with a precision of 18 and a scale of 2, which means it can store numbers with up to 18 digits in total, including 2 digits after the decimal point.
    [Column(TypeName = "decimal(18, 2)")]

    // define a property named Price of type decimal, which will be used to store the price of the movie.
    public decimal Price { get; set; }

    //add a rating property to the Movie class, which will be used to store the rating of the movie.
    public string? Rating { get; set; }
}