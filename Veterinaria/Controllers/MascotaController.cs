using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class MascotaController : Controller
    {
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = "Mascota registrada con éxito.";
                return View();
            }
            return View(mascota);
        }
    }
}
