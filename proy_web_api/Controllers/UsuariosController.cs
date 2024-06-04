using Azure.Core;
using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proy_web_api.Database;
using proy_web_api.Models;
using System.Net;
//polastri
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace proy_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<UsuariosController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {   
            var result = await _context.Usuarios.ToListAsync();
         //   Console.WriteLine(result);
            if(result == null) 
                return NotFound();
            return Ok(result);
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _context.Usuarios.SingleOrDefaultAsync(x => x.id == id);
            //   Console.WriteLine(result);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        //document_number

        [HttpGet("dni/{document_number}")]
        public async Task<IActionResult> Get(string document_number)
        {
            var result = await _context.Usuarios.SingleOrDefaultAsync(x => x.document_number == document_number);
            //   Console.WriteLine(result);
            //  res.status(404).send("Parece que te has perdido")
            if (document_number.Length > 8)
                ///Response.StatusCode = 404; //return  // StatusCode = 404;
                return NotFound("Error en el tamaño de digitos");
            if (result == null)
                return NotFound();
            return Ok(result);

        }
        // POST api/<UsuariosController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuarios usuarios)
        {
            await _context.Usuarios.AddAsync(usuarios);
            await _context.SaveChangesAsync();
            return Ok(usuarios);
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Usuarios usuarios)
        {
            var usuarioInfo = _context.Usuarios.SingleOrDefault(x => x.id == id);
            if(usuarioInfo == null)
                return NotFound();
            usuarioInfo.name = usuarios.name;
            usuarioInfo.document_number = usuarios.document_number;
            usuarioInfo.salary = usuarios.salary;
            usuarioInfo.age = usuarios.age;
            usuarioInfo.profile = usuarios.profile;
            usuarioInfo.admission_date = usuarios.admission_date;
            _context.Attach(usuarioInfo);
            await _context.SaveChangesAsync();
            return Ok(usuarioInfo);

        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var usuarioInfo = _context.Usuarios.SingleOrDefault(x => x.id == id);
            if (usuarioInfo == null)
                return NotFound();
            _context.Usuarios.Remove(usuarioInfo);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
