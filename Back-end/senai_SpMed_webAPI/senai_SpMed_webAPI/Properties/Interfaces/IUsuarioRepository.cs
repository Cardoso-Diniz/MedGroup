using senai_SpMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Interfaces
{
    interface IUsuarioRepository 
    {
        List<Usuario> Listar();
        Usuario BuscarPorId(int id);
        void Cadastrar(Usuario novaUsuario);
        void Atualizar(int idUsuario, Usuario UsuarioAtualizada);
        void Deletar(int idUsuario, Usuario UsuarioDeletar);
    }
}
