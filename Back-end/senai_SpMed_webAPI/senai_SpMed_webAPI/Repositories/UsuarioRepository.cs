using senai_SpMed_webAPI.Contexts;
using senai_SpMed_webAPI.Domains;
using senai_SpMed_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        MedGroupContext ctx = new MedGroupContext();
        public void Atualizar(int idUsuario, Usuario UsuarioAtualizada)
        {
            Usuario ConBuscada = ctx.UsuariosPossui.Find(idUsuario);
            if (UsuarioAtualizada.TituloUsuario != null)
            {
                ConBuscada.TituloUsuario = UsuarioAtualizada.TituloUsuario;
            }
            ctx.UsuariosPossui.Update(ConBuscada);
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.UsuariosPossui.FirstOrDefault(e => e.IdUsuario == id);
        }
        
        public void Cadastrar(Usuario novaUsuario)
        {
            ctx.Update(novaUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario UsuarioDeletar = ctx.UsuariosPossui.Find(id);
            ctx.UsuariosPossui.Remove(UsuarioDeletar);
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.UsuariosPossui.ToList();
        }
    }
}
