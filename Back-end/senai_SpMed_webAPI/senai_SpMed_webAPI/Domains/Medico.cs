﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SpMed_webAPI.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdMedico { get; set; }
        public int? IdUsuarioPossui { get; set; }
        public int? IdClinica { get; set; }
        public int? IdPaciente { get; set; }
        public string NomeMedico { get; set; }
        public string Crm { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Clinica IdClinicaNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual UsuarioPossui IdUsuarioPossuiNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}