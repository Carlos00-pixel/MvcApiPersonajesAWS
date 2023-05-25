using Microsoft.AspNetCore.Mvc;
using MvcApiPersonajesAWS.Services;

namespace MvcApiPersonajesAWS.Controllers
{
    public class PersonajesController : Controller
    {
        private ServicePersonajes service;

        public PersonajesController(ServicePersonajes service)
        {
            this.service = service;
        }

        public IActionResult Cliente()
        {
            return View();
        }

        public IActionResult Personajes()
        {
            return View();
        }
    }
}
