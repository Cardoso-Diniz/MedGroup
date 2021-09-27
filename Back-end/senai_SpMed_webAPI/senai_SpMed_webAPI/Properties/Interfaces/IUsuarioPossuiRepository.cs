using senai_SpMed_webAPI.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Interfaces
{
    interface IUsuarioPossuiRepository
    {
        UsuarioPossuiDomain Login(string email, string senha);
    }
}
