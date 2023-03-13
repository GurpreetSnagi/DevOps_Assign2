using System.ComponentModel.DataAnnotations;

namespace Assignment2_531.Models
{
    public class Student
    {
        // EF Core will configure the database to generate this value
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please enter first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter Last name.")]
        public string? LastName { get; set; } = string.Empty;
    }
}
