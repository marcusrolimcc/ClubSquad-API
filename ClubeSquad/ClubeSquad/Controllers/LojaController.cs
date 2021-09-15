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
    public class LojaController : ControllerBase
    {
        public Contexto Contexto;

        public LojaController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<LojaController>
        [HttpGet]
        [Route("listar")]
        public List<Loja> Listar()
        {
            return Contexto.Lojas.ToList();
        }

        // POST api/<LojaController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Loja>> Incluir(Loja loja)
        {
            loja.Id = 0;
            Contexto.Lojas.Add(loja);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = loja.Id });
        }

        // PUT api/<LojaController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Loja>> Alterar(Loja loja)
        {
            Contexto.Update(loja);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = loja.Id });
        }
    }
}
