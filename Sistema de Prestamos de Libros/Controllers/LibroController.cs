using Microsoft.AspNetCore.Mvc;

namespace Sistema_de_Prestamos_de_Libros.Controllers
{
    public class LibroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
