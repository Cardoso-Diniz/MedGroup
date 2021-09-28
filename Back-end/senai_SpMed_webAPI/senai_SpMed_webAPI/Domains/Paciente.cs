using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SpMed_webAPI.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consultum>();
            Medicos = new HashSet<Medico>();
        }

        public int IdPaciente { get; set; }
        public int? IdUsuarioPossui { get; set; }
        public int? IdEndereco { get; set; }
        public string NomePaciente { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public int? IdEspecialidade { get; set; }

        public virtual Endereco IdEnderecoNavigation { get; set; }
        public virtual Especialidade IdEspecialidadeNavigation { get; set; }
        public virtual UsuarioPossui IdUsuarioPossuiNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
