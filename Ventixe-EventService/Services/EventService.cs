using Ventixe_EventService.Models;

namespace Ventixe_EventService.Services
{
    public class EventService
    {   // Creating a readonly List, that takes in the Event model, and we name the list _events, and then we set the properties of our mockdata events.
        private readonly List<Event> _events = new()
        {
            new Event { Id = 1, Title = "Symphony Under the Stars", DateTime = new DateTime(2029, 2, 15, 10, 30, 0), Type = "Concert", Location = "Central Park", Price = 100 },
            new Event { Id = 2, Title = "Runway Revolution 2024", DateTime = new DateTime(2029, 2, 16, 15, 45, 0), Type = "Sport", Location = "Fashion Hall", Price = 120 },
            new Event { Id = 3, Title = "Global Wellness Summit", DateTime = new DateTime(2029, 2, 17, 13, 15, 0), Type = "Beauty", Location = "Wellness Arena", Price = 240 },
        };

        //creating a IEnumerable, to have an easy way of itterating through and fetchin all the objects from the _events list.
        public IEnumerable<Event> GetAll() => _events;

        //Itterating through the list of events(_events) and returning the event mathinc the id. 
        //The Event can be null, since we are not sure we are getting any event back on the id.
        public Event? GetById(int id) => _events.FirstOrDefault(e => e.Id == id);
    }
}
