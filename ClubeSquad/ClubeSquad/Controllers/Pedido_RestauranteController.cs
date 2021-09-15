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
    public class Pedido_RestauranteController : ControllerBase
    {
        public Contexto Contexto;

        public Pedido_RestauranteController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<Pedido_RestauranteController>
        [HttpGet]
        [Route("listar")]
        public List<Pedido_Restaurante> Listar()
        {
            return Contexto.Pedido_Restaurantes.ToList();
        }

        // POST api/<Pedido_RestauranteController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Pedido_Restaurante>> Incluir(Pedido_Restaurante pedido_Restaurante)
        {
            pedido_Restaurante.Id = 0;
            Contexto.Pedido_Restaurantes.Add(pedido_Restaurante);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = pedido_Restaurante.Id });
        }

        // PUT api/<Pedido_RestauranteController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Pedido_Restaurante>> Alterar(Pedido_Restaurante pedido_Restaurante)
        {
            Contexto.Update(pedido_Restaurante);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = pedido_Restaurante.Id });
        }
    }
}
