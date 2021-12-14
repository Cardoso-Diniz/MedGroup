using senai_SpMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Interfaces
{
    interface IMedicoRepository
    {
        List<Medico> Listar();
        Medico Buscar(int id);
        void Cadastrar(Medico mediconovo);
        void Atualizar(Medico medicoatualizado, int id);
        void Deletar(int id);
    }
}
