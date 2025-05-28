using Microsoft.AspNetCore.Mvc;
using Ventixe_EventService.Models;
using Ventixe_EventService.Services;

namespace Ventixe_EventService.Controllers;
[ApiController]
[Route("api/[controller]")]

public class EventsController : ControllerBase
{
    private readonly EventService _eventService;

    public EventsController(EventService eventService)
    {
        _eventService = eventService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Event>> GetAll()
    {
        return Ok(_eventService.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<Event> GetById(int id)
    {
        var eventResult = _eventService.GetById(id);
        return eventResult == null ? NotFound() : Ok(eventResult);
    }
}
