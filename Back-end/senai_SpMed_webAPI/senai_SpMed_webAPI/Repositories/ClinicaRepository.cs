using senai_SpMed_webAPI.Contexts;
using senai_SpMed_webAPI.Domains;
using senai_SpMed_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        MedGroupContext ctx = new MedGroupContext();
        public void Atualizar(int idClinica, Clinica clinicaAtualizada)
        {
            Clinica clinicaBuscada = BuscarPorId(idClinica);

            if (clinicaAtualizada.IdEndereco != null && clinicaAtualizada.NomeDado != null && clinicaAtualizada.Cpnj != null && clinicaAtualizada.RazaoSocial != null && clinicaAtualizada.AberturaHorario != null && clinicaAtualizada.FechamentoHorario != null)
            {
                clinicaBuscada.IdEndereco = clinicaAtualizada.IdEndereco;
                clinicaBuscada.NomeDado = clinicaAtualizada.NomeDado;
                clinicaBuscada.Cpnj= clinicaAtualizada.Cpnj;
                clinicaBuscada.RazaoSocial = clinicaAtualizada.RazaoSocial;
                clinicaBuscada.AberturaHorario = clinicaAtualizada.AberturaHorario;
                clinicaBuscada.FechamentoHorario = clinicaAtualizada.FechamentoHorario;

            }
            ctx.Clinicas.Update(clinicaBuscada);

            ctx.SaveChanges();
        }

        public Clinica BuscarPorId(int idClinica)
        {
            return ctx.Clinicas.FirstOrDefault(c => c.IdClinica == idClinica);
        }

        public void Cadastrar(Clinica novaClinica)
        {
            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();
        }

        public void Deletar(int idClinica)
        {
            Clinica clinicaBuscada = BuscarPorId(idClinica);

            ctx.Clinicas.Remove(clinicaBuscada);

            ctx.SaveChanges();
        }

        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas
                .Select(c => new Clinica
                {
                    IdClinica = c.IdClinica,
                    IdEnderecoNavigation = new Endereco
                    {
                        Rua = c.IdEnderecoNavigation.Rua,
                        Numero = c.IdEnderecoNavigation.Numero,
                        Bairro = c.IdEnderecoNavigation.Bairro,
                        Cidade = c.IdEnderecoNavigation.Cidade,
                        Cep = c.IdEnderecoNavigation.Cep
                    },
                    NomeDado = c.NomeDado,
                    Cpnj = c.Cpnj,
                    RazaoSocial = c.RazaoSocial,
                    AberturaHorario = c.AberturaHorario,
                    FechamentoHorario = c.FechamentoHorario,
                    Medicos = c.Medicos
                }).ToList();
        }
    }
}
