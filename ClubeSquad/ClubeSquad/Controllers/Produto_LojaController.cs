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
    public class Produto_LojaController : ControllerBase
    {
        public Contexto Contexto;

        public Produto_LojaController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<Produto_LojaController>
        [HttpGet]
        [Route("listar")]
        public List<Produto_Loja> Listar()
        {
            return Contexto.Produto_Lojas.ToList();
        }

        // POST api/<Produto_LojaController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Produto_Loja>> Incluir(Produto_Loja produto_Loja)
        {
            produto_Loja.Id = 0;
            Contexto.Produto_Lojas.Add(produto_Loja);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = produto_Loja.Id });
        }

        // PUT api/<Produto_LojaController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Produto_Loja>> Alterar(Produto_Loja produto_Loja)
        {
            Contexto.Update(produto_Loja);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = produto_Loja.Id });
        }
    }
}
