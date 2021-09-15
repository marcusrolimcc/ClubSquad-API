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
    public class FuncionarioController : ControllerBase
    {
        public Contexto Contexto;

        public FuncionarioController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<FuncionarioController>
        [HttpGet]
        [Route("listar")]
        public List<Funcionario> Listar()
        {
            return Contexto.Funcionarios.ToList();
        }

        // POST api/<FuncionarioController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Funcionario>> Incluir(Funcionario funcionario)
        {
            funcionario.Id = 0;
            Contexto.Funcionarios.Add(funcionario);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = funcionario.Id });
        }

        // PUT api/<FuncionarioController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Funcionario>> Alterar(Funcionario funcionario)
        {
            Contexto.Update(funcionario);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = funcionario.Id });
        }
    }
}
