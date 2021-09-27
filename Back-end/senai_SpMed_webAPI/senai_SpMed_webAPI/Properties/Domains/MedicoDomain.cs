using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Domains
{
    public class MedicoDomain
    {
        public int idMedico { get; set; }
        public int UsuarioPossui { get; set; }
        public int idClinica { get; set; }
        public int idPaciente { get; set; }
        public string NomeMedico { get; set; }
        public string CRM { get; set; }
    }
}
