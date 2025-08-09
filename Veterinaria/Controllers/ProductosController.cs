using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Lista()
        {
            var productos = new List<Producto>
            {
                new Producto { Id=1, Nombre="Collar para perro", Descripcion="Collar ajustable y resistente", Precio=25.99m, ImagenUrl="/Images/Collar.jpeg" },
                new Producto { Id=2, Nombre="Comida para gato", Descripcion="Bolsa de 2kg de alimento premium", Precio=45.50m, ImagenUrl="/Images/ComidaGato.jpeg" },
                new Producto { Id=3, Nombre="Juguete para mascota", Descripcion="Pelota resistente para juegos", Precio=15.00m, ImagenUrl="/Images/Juguete.jpeg" }
            };

            return View(productos);
        }
    }
}
