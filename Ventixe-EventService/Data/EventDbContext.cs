using System.Data.Entity;
using Ventixe_EventService.Models;

namespace Ventixe_EventService.Data;

public class EventDbContext : DbContext
{
    //public EventDbContext(DbContextOptions<EventDbContext> options) : base(options) { }

    public DbSet<Event> Events => Set<Event>();
}
