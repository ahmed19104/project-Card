using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace final_project1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int CourseId { get; set; }
        //public IFormFile ProfilePicture { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select a valid Category.")]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        [ValidateNever]
        public Course Course { get; set; }
    }
}
