using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioWebApi.Model;

namespace ServicioWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmigosController : ControllerBase
    {
        // aplico IoC
        private readonly Contexto _contexto;
        public AmigosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public List<Amigo> GetAll()
        {
            var listaAmigos = from a in _contexto.Amigo select a;
            return listaAmigos.ToList();
        }
        [HttpGet("{id}")] public ActionResult<Amigo> GetById(int id)
        {
            var amigo = _contexto.Amigo.Find(id);
            if (amigo == null)
            {
                return NotFound(); // codigo 404
            }
            return Ok(amigo); // codigo 200
        }
    }
}
