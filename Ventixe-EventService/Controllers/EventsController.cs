using Microsoft.AspNetCore.Mvc;

namespace Ventixe_EventService.Controllers;

public class EventsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
