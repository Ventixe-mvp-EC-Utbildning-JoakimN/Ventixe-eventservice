using Ventixe_EventService.Models;

namespace Ventixe_EventService.Data;

public static class SeedData
{
    public static void Initialize(EventDbContext dbContext)
    {
        if (dbContext.Events.Any())
        {
            return;
        }

        var events = new List<Event>
{
            new Event {
                Title = "Symphony Under the Stars",
                Description = "Enjoy a magical night of classical music performed outdoors under a starlit sky.",
                DateTime = new DateTime(2029, 2, 15, 10, 30, 0),
                Type = "Concert",
                Location = "Central Park",
                Price = 100,
            },
            new Event {
                Title = "Runway Revolution 2024",
                Description = "A cutting-edge fashion showcase featuring bold designs from the industry's rising stars.",
                DateTime = new DateTime(2029, 2, 16, 15, 45, 0),
                Type = "Sport",
                Location = "Fashion Hall",
                Price = 120,
            },
            new Event {
                Title = "Global Wellness Summit",
                Description = "An empowering event focused on holistic health, mindfulness, and wellness trends.",
                DateTime = new DateTime(2029, 2, 17, 13, 15, 0),
                Type = "Beauty",
                Location = "Wellness Arena",
                Price = 240,
            },
            new Event {
                Title = "Deep Dive ASP.NET",
                Description = "A full-day developer workshop exploring advanced features of ASP.NET Core.",
                DateTime = new DateTime(2027, 3, 2, 21, 15, 0),
                Type = "Lecture",
                Location = "Avicii Arena",
                Price = 300,
            },
            new Event {
                Title = "Artistry Unveiled: Modern Art Expo",
                Description = "Immerse yourself in bold and contemporary expressions at this acclaimed art expo.",
                DateTime = new DateTime(2029, 2, 18, 17, 30, 0),
                Type = "Fashion",
                Location = "Vogue Hall",
                Price = 50,
            },
            new Event {
                Title = "Culinary Delights Festival",
                Description = "Taste your way through gourmet experiences crafted by world-renowned chefs.",
                DateTime = new DateTime(2029, 3, 3, 12, 0, 0),
                Type = "Food & Culinary",
                Location = "Gourmet Plaza",
                Price = 40,
            },
            new Event {
                Title = "Tech Tomorrow Conference",
                Description = "Explore emerging tech trends and innovations that will shape the future.",
                DateTime = new DateTime(2029, 3, 12, 10, 0, 0),
                Type = "Technology",
                Location = "Digital Dome",
                Price = 300,
            },
            new Event {
                Title = "Spring Jazz Brunch",
                Description = "Savor a brunch buffet accompanied by smooth, live jazz performances.",
                DateTime = new DateTime(2029, 3, 17, 11, 0, 0),
                Type = "Concert",
                Location = "Harmony Café",
                Price = 70,
            },
            new Event {
                Title = "Eco Future Talks",
                Description = "Inspiring talks on sustainability, renewable energy, and a greener tomorrow.",
                DateTime = new DateTime(2029, 4, 5, 14, 30, 0),
                Type = "Education",
                Location = "Green Center",
                Price = 25,
            },
            new Event {
                Title = "Mountain Film Festival",
                Description = "Experience breathtaking films that capture nature, adventure, and the human spirit.",
                DateTime = new DateTime(2029, 4, 20, 18, 0, 0),
                Type = "Film",
                Location = "Summit Theater",
                Price = 80,
            },
            new Event {
                Title = "Night Market Fiesta",
                Description = "Celebrate culture and cuisine at this vibrant night market full of music and flavor.",
                DateTime = new DateTime(2029, 4, 28, 19, 0, 0),
                Type = "Food & Culture",
                Location = "Downtown Plaza",
                Price = 35,
            }
        };


        dbContext.Events.AddRange(events);
        dbContext.SaveChanges();
    }
}
