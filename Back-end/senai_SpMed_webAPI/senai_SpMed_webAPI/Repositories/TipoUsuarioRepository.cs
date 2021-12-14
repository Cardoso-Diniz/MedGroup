using Microsoft.EntityFrameworkCore;
using senai_SpMed_webAPI.Contexts;
using senai_SpMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        MedGroupContext ctx = new MedGroupContext();
        public void Atualizar(int id, TipoUsuario NovoTipoUsuario)
        {
            TipoUsuario UTipoBuscado = ctx.TipoUsuarios.Find(id);

            if (NovoTipoUsuario.TituloTipoUsuario != null)
            {
                UTipoBuscado.TituloTipoUsuario = NovoTipoUsuario.TituloTipoUsuario;
            }

            ctx.TipoUsuarios.Update(UTipoBuscado);
            ctx.SaveChanges();
        }

        public void Cadastrar(TipoUsuario NovoTipoUsuario)
        {
            ctx.TipoUsuarios.Add(NovoTipoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoUsuario UTipoBuscado = ctx.TipoUsuarios.Find(id);
            ctx.TipoUsuarios.Remove(UTipoBuscado);
            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios.ToList();
        }

        public List<TipoUsuario> ListarUser()
        {
            return ctx.TipoUsuarios.
               Include(e => e.Usuarios).ToList();
        }
    }
}
