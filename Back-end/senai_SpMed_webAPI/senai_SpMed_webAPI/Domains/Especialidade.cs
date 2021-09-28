using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SpMed_webAPI.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public int IdEspecialidade { get; set; }
        public string NomeEspecialidades { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
