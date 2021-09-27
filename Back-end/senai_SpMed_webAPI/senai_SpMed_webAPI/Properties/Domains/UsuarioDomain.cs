using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Domains
{
    public class UsuarioDomain
    {
        internal string titulo;

        public int idUsuario { get; set; }
        public string TituloUsuario { get; set; }

        public static implicit operator string(UsuarioDomain v)
        {
            throw new NotImplementedException();
        }
    }
}
