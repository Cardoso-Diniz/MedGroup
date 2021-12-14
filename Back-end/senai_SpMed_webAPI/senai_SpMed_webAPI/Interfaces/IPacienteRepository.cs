using senai_SpMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Interfaces
{
    interface IPacienteRepository
    {
        List<Paciente> Listar();
        List<Paciente> ListarTudo();
        Paciente BuscarPorId(int id);
        void Cadastrar(Paciente NovoPaciente);
        void Deletar(int id);
        void Atualizar(int id, Paciente NovoPaciente);
    }
}
