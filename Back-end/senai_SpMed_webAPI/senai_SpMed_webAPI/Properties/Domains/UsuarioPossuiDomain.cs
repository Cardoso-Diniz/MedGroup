using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Domains
{
    public class UsuarioPossuiDomain
    {
        public int idUsuarioPossui { get; set; }
        public int idUsuario { get; set; }
        [Required(ErrorMessage = "Informe o e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe a senha")]

        public string Senha { get; set; }
    }
}
