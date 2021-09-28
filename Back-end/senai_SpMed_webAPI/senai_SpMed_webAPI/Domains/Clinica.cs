using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SpMed_webAPI.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdClinica { get; set; }
        public int? IdEndereco { get; set; }
        public string NomeDado { get; set; }
        public string Cpnj { get; set; }
        public string RazaoSocial { get; set; }
        public string AberturaHorario { get; set; }
        public string FechamentoHorario { get; set; }

        public virtual Endereco IdEnderecoNavigation { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
