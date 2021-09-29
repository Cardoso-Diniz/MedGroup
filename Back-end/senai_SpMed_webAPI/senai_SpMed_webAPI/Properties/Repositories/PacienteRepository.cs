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
            Paciente novaPaciente = ctx.Pacientes.Find(idPaciente);
            if (PacienteAtualizada.NomePaciente != null)
            {
                novaPaciente.NomePaciente = PacienteAtualizada.NomePaciente;
            }

            if (PacienteAtualizada.Telefone != null)
            {
                novaPaciente.Telefone = PacienteAtualizada.Telefone;
            }
            ctx.Pacientes.Update(novaPaciente);
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
            Paciente novaPaciente = ctx.Pacientes.Find(id);
            ctx.Pacientes.Remove(novaPaciente);
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
