using System.ComponentModel.DataAnnotations;

namespace MovieTracker.Models;

public class Movie
{
    [Key]

    public int MovieId { get; set; }
    [Required]
    public string Title { get; set; } = " ";

    [DataType(DataType.Date)]
    [Display(Name ="Date Seen")]
    public DateTime? DateSeen { get; set; }

    public string? Genre { get; set; }

    [Range(1,10)]
    public int? MyRating { get; set; }
}
