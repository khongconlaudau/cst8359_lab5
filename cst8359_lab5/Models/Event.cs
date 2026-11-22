using System.ComponentModel.DataAnnotations;

namespace cst8359_lab5.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        [Required]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;
        public List<Attendee> Attendees { get; set; } = new();

    }
}
