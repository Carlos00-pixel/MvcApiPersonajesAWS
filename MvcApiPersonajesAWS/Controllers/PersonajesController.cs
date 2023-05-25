using Microsoft.AspNetCore.Mvc;

namespace MvcApiPersonajesAWS.Controllers
{
    public class PersonajesController : Controller
    {
        public IActionResult Personajes()
        {
            return View();
        }
    }
}
