using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_SpMed_webAPI.Domains;
using senai_SpMed_webAPI.Properties.Interfaces;
using senai_SpMed_webAPI.Properties.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private IPacienteRepository Pac { get; set; }

        public PacienteController()
        {
            Pac = new PacienteRepository();
        }

        //[Authorize(Roles = "3")]
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(Pac.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[Authorize(Roles = "3")]
        [HttpGet("Tudo")]
        public IActionResult ListarTudo()
        {
            try
            {
                return Ok(Pac.ListarTudo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Cadastro(Paciente NovoPac)
        {
            try
            {
                Pac.Cadastrar(NovoPac);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[Authorize(Roles = "2")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                Pac.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[Authorize(Roles = "2")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Paciente NovoPac)
        {
            try
            {
                Pac.Atualizar(id, NovoPac);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
