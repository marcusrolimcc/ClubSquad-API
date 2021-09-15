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
    public class ClienteController : ControllerBase
    {
        public Contexto Contexto;

        public ClienteController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        [Route("listar")]
        public List<Cliente> Listar()
        {
            return Contexto.Clientes.ToList();
        }

        // POST api/<ClienteController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Cliente>> Incluir(Cliente cliente)
        {
            cliente.Id = 0;
            Contexto.Clientes.Add(cliente);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = cliente.Id });
        }

        // PUT api/<ClienteController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Cliente>> Alterar(Cliente cliente)
        {
            Contexto.Update(cliente);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = cliente.Id });
        }
    }
}
