using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class CourseModel
    {
        [Required]
        [MinLength(5,ErrorMessage = "Title minimum length should be 5")]
        [MaxLength(50,ErrorMessage = "Title Length is  50")]
        public string Title { get; set; }
        [Required]
        [NonZeroIntiger]
        public int SeatCount { get; set; }
        [Required]
        [NonZeroIntiger]
        public int Fee { get; set; }
    }
}