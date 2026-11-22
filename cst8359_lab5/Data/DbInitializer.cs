using cst8359_lab5.Models;

namespace cst8359_lab5.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Events.Any())
            {
                return;
            }

            var events = new List<Event>
            {
                new Event
                {
                    Title = "Campus Career Fair",
                    Description = "Meet employers and explore internship opportunities.",
                    Date = new DateTime(2026, 12, 1, 10, 0, 0),
                    Location = "Gym",
                    Attendees =
                    {
                        new Attendee { Id = "cf-john", Name = "John Wick", Email = "john@example.com" },
                        new Attendee { Id = "cf-blair", Name = "Blair Singh", Email = "blair@example.com" }
                    }
                },
                new Event
                {
                    Title = "Tech Talk",
                    Description = "A short talk on building web applications with ASP.NET Core.",
                    Date = new DateTime(2027, 1, 15, 14, 0, 0),
                    Location = "Auditorium",
                    Attendees =
                    {
                        new Attendee { Id = "tt-casey", Name = "Casey Roy", Email = "casey@example.com" },
                        new Attendee { Id = "tt-dana", Name = "Dana Cole", Email = "dana@example.com" }
                    }
                },
                new Event
                {
                    Title = "Hack Night",
                    Description = "An evening build session for student project teams.",
                    Date = new DateTime(2027, 2, 5, 18, 0, 0),
                    Location = "Library",
                    Attendees =
                    {
                        new Attendee { Id = "hn-evan", Name = "Evan Park", Email = "evan@example.com" },
                        new Attendee { Id = "hn-farah", Name = "Farah Ali", Email = "farah@example.com" }
                    }
                }
            };

            context.Events.AddRange(events);
            context.SaveChanges();

        }
    }
}
