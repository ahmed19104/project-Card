using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace final_project1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ValidateNever]
        public string Description { get; set; }
    }
}
