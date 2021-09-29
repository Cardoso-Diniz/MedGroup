using Microsoft.EntityFrameworkCore;
using senai_SpMed_webAPI.Contexts;
using senai_SpMed_webAPI.Domains;
using senai_SpMed_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Repositories
{
    public class UsuarioPossuiRepository : IUsuarioPossuiRepository
    {
        MedGroupContext ctx = new MedGroupContext();
        public void Cadastrar(UsuarioPossui novaUsuarioPossui)
        {
            ctx.Consulta.Update(novaUsuarioPossui);
            ctx.SaveChanges();
        }
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

        public void Deletar(int idUsuarioPossui, UsuarioPossui UsuarioPossuiDeletar)
        {
            {
                UsuarioPossui UsuarioPossuiDeletar = ctx.UsuarioPossuis.Find(idUsuarioPossui);
                ctx.Consulta.Remove(UsuarioPossuiDeletar);
                ctx.SaveChanges();
            }
        }


        public List<UsuarioPossui> Listar()
        {
            return ctx.UsuarioPossuis.ToList();
        }
        }
    }
