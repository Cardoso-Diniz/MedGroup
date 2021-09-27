using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Domains
{
    public class EnderecoDomain
    {
        public int idEndereco { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }

        public string Cidade { get; set; }
        public string Cep { get; set; }
    }
}
