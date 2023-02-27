using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.Models
{
    public class Users1
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;


       
        public decimal Phone { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; } = null!;
    }
}
