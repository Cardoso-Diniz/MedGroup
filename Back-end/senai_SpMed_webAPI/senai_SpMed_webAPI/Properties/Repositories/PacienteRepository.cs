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
    public class PacienteRepository : IPacienteRepository
    {
        MedGroupContext ctx = new MedGroupContext();
        public void Atualizar(int idPaciente, Paciente PacienteAtualizada)
        {
            Paciente PacBuscado = ctx.Pacientes.Find(idPaciente);
            if (PacienteAtualizada.NomePaciente != null)
            {
                PacBuscado.NomePaciente = PacienteAtualizada.NomePaciente;
            }

            if (PacienteAtualizada.Telefone != null)
            {
                PacBuscado.Telefone = PacienteAtualizada.Telefone;
            }
            ctx.Pacientes.Update(PacBuscado);
            ctx.SaveChanges();
        }

        public Paciente BuscarPorId(int id)
        {
            return ctx.Pacientes.FirstOrDefault(e => e.IdPaciente == id);
        }

        public void Cadastrar(Paciente novaPaciente)
        {
            ctx.Pacientes.Update(novaPaciente);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Paciente PacBuscado = ctx.Pacientes.Find(id);
            ctx.Consulta.Remove(PacBuscado);
            ctx.SaveChanges();
        }

        public List<Paciente> Listar()
        {
            return ctx.Pacientes.ToList();
        }

        public List<Paciente> ListarTudo()
        {
            return ctx.Pacientes
            .Include(e => e.Consulta)
            .ToList();
        }
    }
}
