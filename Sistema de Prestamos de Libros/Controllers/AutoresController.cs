using Microsoft.AspNetCore.Mvc;
using Sistema_de_Prestamos_de_Libros.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sistema_de_Prestamos_de_Libros.Controllers
{
    [Route("api/libros/antes-de-2000:")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        // GET: api/<AutoresController>
        [HttpGet]
        public IEnumerable<> Get()
        {
            return int new [] { 1, 2};
        }

        // GET api/<AutoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Autor_Id, Nombre, Nacionalidad";
        }

        // POST api/<AutoresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AutoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AutoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
