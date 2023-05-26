using Microsoft.AspNetCore.Mvc;
using MvcApiPersonajesAWS.Models;
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

        public async Task<IActionResult> Servidor()
        {
            List<Personaje> personajes =
                await this.service.GetPersonajesAsync();
            return View(personajes);
        }

        public IActionResult Personajes()
        {
            return View();
        }
    }
}
