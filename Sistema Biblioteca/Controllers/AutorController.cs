using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Biblioteca.Context;

namespace Sistema_Biblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly BibliotecaContext _context;
        public AutorController(BibliotecaContext context)
        {
            _context = context;
        }

        // GET: api/autor
        [HttpGet]
        public IActionResult GetAutor()
        {
            var autor = _context.Autores.ToList();
            return Ok(autor);
        }

        // GET: api/autor
        public IActionResult GetAutor(int id)
        {
            var autor = _context.Autores.Find(id);
            if (autor == null)
                return NotFound();
            return Ok(autor);
        }

        // GET: AutoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

      
        }
    }
