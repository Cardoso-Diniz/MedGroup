using senai_SpMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Interfaces
{
    interface ITipoUsuario
    {
        List<TipoUsuario> Listar();
        List<TipoUsuario> ListarUser();
        void Cadastrar(TipoUsuario NovoTipoUsuario);
        void Deletar(int id);
        void Atualizar(int id, TipoUsuario NovoTipoUsuario);
    }
}
    