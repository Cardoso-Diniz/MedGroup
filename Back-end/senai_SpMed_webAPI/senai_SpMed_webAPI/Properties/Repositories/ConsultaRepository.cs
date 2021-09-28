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
    public class ConsultaRepository : IConsultaRepository
    {
        MedGroupContext ctx = new MedGroupContext();

        public void Atualizar(int idConsulta, Consultum ConsultaAtualizada)
        {
            Consultum ConBuscada = ctx.Consulta.Find(idConsulta);
            if (ConsultaAtualizada.DescricaoConsulta != null)
            {
                ConBuscada.DescricaoConsulta = ConsultaAtualizada.DescricaoConsulta;
            }
            ctx.Consulta.Update(ConBuscada);
            ctx.SaveChanges();
        }

        public Consultum BuscarPorId(int id)
        {
            return ctx.Consulta.FirstOrDefault(e => e.IdConsulta == id);
        }

        public void Cadastrar(Consultum novaConsulta)
        {
            ctx.Consulta.Update(novaConsulta);
            ctx.SaveChanges();
        }

        public void Deletar(int idConsulta, Consultum ConsultaDeletar)
        {
            Consultum ConBuscada = ctx.Consulta.Find(idConsulta);
            ctx.Consulta.Remove(ConBuscada);
            ctx.SaveChanges();
        }

        public List<Consultum> ListarCon()
        {
            return ctx.Consulta.ToList();
        }

        public List<Consultum> ListarTudo()
        {
            return ctx.Consulta
            .Include(e => e.IdPacienteNavigation)
            .Include(e => e.IdMedicoNavigation)
            .Include(e => e.IdSituacaoNavigation)
            .ToList();
        }

        public List<Consultum> MedicoCon(int id)
        {
            Medico MedBuscado = ctx.Medicos.FirstOrDefault(e => e.IdUsuarioPossui == id);
            return ctx.Consulta
            .Include(e => e.IdPacienteNavigation)
            .Include(e => e.IdSituacaoNavigation)
            .Where(e => e.IdMedico == MedBuscado.IdMedico)
            .ToList();
        }

        public List<Consultum> PacienteCon(int id)
        {
            Paciente PacBuscado = ctx.Pacientes.FirstOrDefault(e => e.IdUsuarioPossui == id);
            return ctx.Consulta
            .Include(e => e.IdMedicoNavigation)
            .Include(e => e.IdMedicoNavigation.IdClinicaNavigation)
            .Include(e => e.IdPacienteNavigation)
            .Where(e => e.IdPaciente == PacBuscado.IdPaciente)
            .ToList();
        }

        public void Status(int idConsulta, string ConsultaStatus)
        {
            Consultum consulta = ctx.Consulta
            .FirstOrDefault(e => e.IdConsulta == idConsulta);
            switch (ConsultaStatus)
            {
                case "1":
                    consulta.IdSituacao = 1;
                    break;

                case "2":
                    consulta.IdSituacao = 2;
                    break;

                case "3":
                    consulta.IdSituacao = 3;
                    break;

                default:
                    consulta.IdSituacao = consulta.IdSituacao;
                    break;
            }

            ctx.Consulta.Update(consulta);
            ctx.SaveChanges();
        }
    }
}
