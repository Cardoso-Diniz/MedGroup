using senai_SpMed_webAPI.Contexts;
using senai_SpMed_webAPI.Domains;
using senai_SpMed_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        MedGroupContext ctx = new MedGroupContext();

        public void Atualizar(Medico medicoatualizado, int id)
        {
            Medico MedicoBuscado = Buscar(id);

            if (medicoatualizado.NomeMed != null)
            {
                MedicoBuscado.NomeMed = medicoatualizado.NomeMed;
            }
            if (medicoatualizado.IdEspecialidade != null)
            {
                MedicoBuscado.IdEspecialidade = medicoatualizado.IdEspecialidade;
            }
            if (medicoatualizado.IdClinica != null)
            {
                MedicoBuscado.IdClinica = medicoatualizado.IdClinica;
            }

            ctx.Medicos.Update(MedicoBuscado);

            ctx.SaveChanges();
        }

        public Medico Buscar(int id)
        {
            return ctx.Medicos.FirstOrDefault(M => M.IdMedico == id);
        }

        public void Cadastrar(Medico mediconovo)
        {
            ctx.Medicos.Add(mediconovo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Medico MedicoBuscado = Buscar(id);

            ctx.Medicos.Remove(MedicoBuscado);

            ctx.SaveChanges();
        }

        public List<Medico> Listar()
        {
            return ctx.Medicos.ToList();
        }
    }
}
