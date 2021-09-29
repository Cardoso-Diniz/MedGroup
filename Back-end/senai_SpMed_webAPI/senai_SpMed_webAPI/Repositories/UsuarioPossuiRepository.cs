using senai_SpMed_webAPI.Contexts;
using senai_SpMed_webAPI.Domains;
using senai_SpMed_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Repositories
{
    public class UsuarioPossuiRepository : IUsuarioPossuiRepository
    {
        MedGroupContext ctx = new MedGroupContext();
        public void Atualizar(int idUsuarioPossui, UsuarioPossui UsuarioPossuiAtualizada)
        {
            UsuarioPossui UsuarioBuscado = BuscarPorId(idUsuarioPossui);
            if (UsuarioPossuiAtualizada.Senha != null || UsuarioPossuiAtualizada.Email != null)
            {
                UsuarioPossuiAtualizada.Email = UsuarioPossuiAtualizada.Email;
                UsuarioPossuiAtualizada.Senha = UsuarioPossuiAtualizada.Senha;

                ctx.UsuarioPossuis.Update(UsuarioPossuiAtualizada);

                ctx.SaveChanges();
            }
        }

        public UsuarioPossui BuscarPorId(int id)
        {
            return ctx.UsuarioPossuis.FirstOrDefault(e => e.IdUsuarioPossui == id);
        }

        public void Cadastrar(UsuarioPossui novaUsuarioPossui)
        {
            ctx.Add(novaUsuarioPossui);
            ctx.SaveChanges();
        }

        public void Deletar(int idUsuarioPossui, UsuarioPossui UsuarioPossuiDeletar)
        {
            UsuarioPossui UsuarioBuscado = ctx.UsuarioPossuis.Find(idUsuarioPossui);
            ctx.UsuarioPossuis.Remove(UsuarioPossuiDeletar);
            ctx.SaveChanges();
        }

        public List<UsuarioPossui> Listar()
        {
            return ctx.UsuarioPossuis.ToList();
        }

        public UsuarioPossui Login(string email, string senha)
        {
            return ctx.UsuarioPossuis.FirstOrDefault(e => e.Email == email && e.Senha == senha);
        }
    }
}

