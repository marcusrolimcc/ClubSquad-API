using ClubeSquad.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        public Contexto Contexto;

        public RestauranteController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<RestauranteController>
        [HttpGet]
        [Route("listar")]
        public List<Restaurante> Listar()
        {
            return Contexto.Restaurantes.ToList();
        }

        // POST api/<RestauranteController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Restaurante>> Incluir(Restaurante restaurante)
        {
            restaurante.Id = 0;
            Contexto.Restaurantes.Add(restaurante);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = restaurante.Id });
        }

        // PUT api/<RestauranteController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Restaurante>> Alterar(Restaurante restaurante)
        {
            Contexto.Update(restaurante);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = restaurante.Id });
        }
    }
}
