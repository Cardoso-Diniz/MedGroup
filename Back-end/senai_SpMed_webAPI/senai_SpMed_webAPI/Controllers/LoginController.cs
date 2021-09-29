using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai_SpMed_webAPI.Domains;
using senai_SpMed_webAPI.Properties.Interfaces;
using senai_SpMed_webAPI.Properties.Repositories;
using senai_SpMed_webAPI.Repositories;
using senai_SpMed_webAPI.ViewModels.cs;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioPossuiRepository _usuarioPossuiRepository { get; set; }

        public LoginController()
        {
            _usuarioPossuiRepository = new UsuarioPossuiRepository();
        }
        [HttpPost()]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                UsuarioPossui usuarioBuscado = _usuarioPossuiRepository.Login(login.Email, login.Senha);
                if (usuarioBuscado == null)
                {
                    return NotFound("Usuario ou senha incorretos");
                }
                var Claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.IdUsuarioPossui.ToString()),
                    new Claim("role", usuarioBuscado.IdUsuarioPossui.ToString()),
                    new Claim("nameUser", usuarioBuscado.Email)
                };
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Medical-chave-autenticacao"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                    (
                        issuer: "MedGrup.webApi",
                        audience: "MedGrup.webApi",
                        claims: Claims,
                        expires: DateTime.Now.AddMinutes(10),
                        signingCredentials: creds
                    );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
