using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Domains
{
    public class PacienteDomain
    {
        public int idPaciente { get; set; }
        public int UsuarioPossui { get; set; }
        public int idEndereco { get; set; }
        public string NomePaciente { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}
