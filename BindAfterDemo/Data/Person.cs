using System.ComponentModel.DataAnnotations;

namespace BindAfterDemo.Data
{
    public class Person
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
    }
}
