using System.ComponentModel.DataAnnotations;

namespace cst8359_lab5.Models
{
    public class Attendee
    {
        [Key]
        [MaxLength(64)]
        public string Id { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;
        public int EventId { get; set; }
        public Event? Event { get; set; }
    }
}
