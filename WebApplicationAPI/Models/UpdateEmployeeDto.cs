using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPI.Models
{
    public class UpdateEmployeeDto
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
