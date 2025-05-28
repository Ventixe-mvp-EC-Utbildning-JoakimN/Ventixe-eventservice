using Microsoft.EntityFrameworkCore;
using Ventixe_EventService.Data;
using Ventixe_EventService.Models;

namespace Ventixe_EventService.Services
{
    public class EventService
    {   
        private readonly EventDbContext _dbContext;

        public EventService(EventDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //creating a IEnumerable, to have an easy way of itterating through and fetchin all the objects from the _events list.
        public IEnumerable<Event> GetAll() => _dbContext.Events.ToList();

        //Itterating through the list of events(_events) and returning the event mathinc the id. 
        //The Event can be null, since we are not sure we are getting any event back on the id.
        public Event? GetById(int id) => _dbContext.Events.FirstOrDefault(e => e.Id == id);
    }
}
