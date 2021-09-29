using senai_SpMed_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SpMed_webAPI.Properties.Interfaces
{
    interface IUsuarioPossuiRepository
    {
        List<Consultum> ListarTudo();
        List<Consultum> ListarCon();
        List<Consultum> MedicoCon(int id);
        List<Consultum> PacienteCon(int id);
        Consultum BuscarPorId(int id);
        void Cadastrar(Consultum novaConsulta);
        void Atualizar(int idConsulta, Consultum ConsultaAtualizada);
        void Deletar (int idConsulta, Consultum ConsultaDeletar);
        void Status (int idConsulta, string ConsultaStatus);

    }
}
