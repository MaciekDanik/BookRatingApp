using System.ComponentModel.DataAnnotations;

namespace BookRating_App
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title{ get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        [DataType(DataType.Date)]
        public DateOnly? RelaseDate { get; set; }
        public float? Rate { get; set; }
        public int? rateCount { get; set; }
        public string? imgUrl { get; set; }
    }
}
