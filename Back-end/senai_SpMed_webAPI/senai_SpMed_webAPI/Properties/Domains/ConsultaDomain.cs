using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Domains
{
    public class ConsultaDomain
    {
        public int idConsulta { get; set; }
        public int idPaciente { get; set; }
        public int idMedico { get; set; }
        public int idSituacao { get; set; }
        public DateTime DataConsulta { get; set; }
        public string DescricaoConsulta { get; set; }
    }
}
