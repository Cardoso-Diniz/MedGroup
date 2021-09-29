using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_SpMed_webAPI.Domains;
using senai_SpMed_webAPI.Properties.Interfaces;
using senai_SpMed_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioPossuiController : ControllerBase
    {
        private IUsuarioPossuiRepository Tipo { get; set; }

        public UsuarioPossuiController()
        {
            Tipo = new UsuarioPossuiRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(Tipo.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(UsuarioPossui novaUsuarioPossui)
        {
            try
            {
                Tipo.Cadastrar(novaUsuarioPossui);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id, UsuarioPossui UsuarioPossuiDeletar)
        {
            try
            {
                Tipo.Deletar(id, UsuarioPossuiDeletar);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, UsuarioPossui  UsuarioPossuiAtualizada)
        {
            try
            {
                Tipo.Atualizar(id, UsuarioPossuiAtualizada);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
