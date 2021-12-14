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

            if (clinicaAtualizada.IdEndereco != null && clinicaAtualizada.NomeClinica != null && clinicaAtualizada.Cnpj != null && clinicaAtualizada.RazaoSocial != null)
            {
                clinicaBuscada.IdEndereco = clinicaAtualizada.IdEndereco;
                clinicaBuscada.NomeClinica = clinicaAtualizada.NomeClinica;
                clinicaBuscada.Cnpj = clinicaAtualizada.Cnpj;
                clinicaBuscada.RazaoSocial = clinicaAtualizada.RazaoSocial;
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
                        Cidade = c.IdEnderecoNavigation.Cidade,
                        Estado = c.IdEnderecoNavigation.Estado,
                        Cep = c.IdEnderecoNavigation.Cep
                    },
                    NomeClinica = c.NomeClinica,
                    Cnpj = c.Cnpj,
                    RazaoSocial = c.RazaoSocial,
                    Medicos = c.Medicos
                }).ToList();
        }
    }
}
