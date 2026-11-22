using System.ComponentModel.DataAnnotations;

namespace cst8359_lab5.DTOs
{
    public class RegisterAttendeeDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;
    }
}
