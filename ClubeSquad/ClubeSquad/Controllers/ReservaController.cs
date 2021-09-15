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
    public class ReservaController : ControllerBase
    {
        public Contexto Contexto;

        public ReservaController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<ReservaController>
        [HttpGet]
        [Route("listar")]
        public List<Reserva> Listar()
        {
            return Contexto.Reservas.ToList();
        }

        // POST api/<ReservaController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Reserva>> Incluir(Reserva reserva)
        {
            reserva.Id = 0;
            Contexto.Reservas.Add(reserva);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = reserva.Id });
        }

        // PUT api/<ReservaController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Reserva>> Alterar(Reserva reserva)
        {
            Contexto.Update(reserva);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = reserva.Id });
        }
    }
}
