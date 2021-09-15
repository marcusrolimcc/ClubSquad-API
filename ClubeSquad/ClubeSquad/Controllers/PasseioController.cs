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
    public class PasseioController : ControllerBase
    {
        public Contexto Contexto;

        public PasseioController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<PasseioController>
        [HttpGet]
        [Route("listar")]
        public List<Passeio> Listar()
        {
            return Contexto.Passeios.ToList();
        }

       // POST api/<PasseioController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Passeio>> Incluir(Passeio passeio)
        {
            passeio.Id = 0;
            Contexto.Passeios.Add(passeio);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = passeio.Id });
        }

        // PUT api/<PasseioController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Passeio>> Alterar(Passeio passeio)
        {
            Contexto.Update(passeio);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = passeio.Id });
        }
    }
}
