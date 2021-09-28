using senai_SpMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Interfaces
{
    interface IUsuarioPossuiPossuiRepository
    {
        UsuarioPossui Login(string email, string senha);
        List<UsuarioPossui> Listar();
        UsuarioPossui BuscarPorId();
        void Cadastrar(UsuarioPossui novaUsuarioPossui);
        void Atualizar(int idUsuarioPossui, UsuarioPossui UsuarioPossuiAtualizada);
        void Deletar(int idUsuarioPossui, UsuarioPossui UsuarioPossuiDeletar);
    }
}
