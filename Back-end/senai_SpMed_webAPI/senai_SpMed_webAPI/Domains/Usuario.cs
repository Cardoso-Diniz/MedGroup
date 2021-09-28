using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SpMed_webAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Medicos = new HashSet<Medico>();
            UsuarioPossuis = new HashSet<UsuarioPossui>();
        }

        public int IdUsuario { get; set; }
        public string TituloUsuario { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<UsuarioPossui> UsuarioPossuis { get; set; }
    }
}
