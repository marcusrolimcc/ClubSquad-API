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
    public class Pedido_LojaController : ControllerBase
    {
        public Contexto Contexto;

        public Pedido_LojaController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<Pedido_LojaController>
        [HttpGet]
        [Route("listar")]
        public List<Pedido_Loja> Listar()
        {
            return Contexto.Pedido_Lojas.ToList();
        }

        // POST api/<Pedido_LojaController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Pedido_Loja>> Incluir(Pedido_Loja pedido_Loja)
        {
            pedido_Loja.Id = 0;
            Contexto.Pedido_Lojas.Add(pedido_Loja);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = pedido_Loja.Id });
        }

        // PUT api/<Pedido_LojaController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Pedido_Loja>> Alterar(Pedido_Loja pedido_Loja)
        {
            Contexto.Update(pedido_Loja);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = pedido_Loja.Id });
        }
    }
}
