using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Domains
{
    public class ClinicaDomain
    {
        public int idClinica { get; set; }
        public int idEndereco { get; set; }
        public string NomeDado { get; set; }
        public string CPNJ { get; set; }
        public string RazaoSocial { get; set; }
        public DateTime AberturaHorario { get; set; }
        public DateTime FechamentoHorario { get; set; }
    }
}
