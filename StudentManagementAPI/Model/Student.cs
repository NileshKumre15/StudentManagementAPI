using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Model
{
    public class Student
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Email { get; set; } = string.Empty;

        public string? ImagePath { get; set; }

    }
}
