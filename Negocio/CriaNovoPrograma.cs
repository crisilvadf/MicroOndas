using neMicroOndas;
using peMicroOndas.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CriaNovoPrograma
    {
        public void Create(string nomePrograma, string descricao, string tempo, string potencia, string instrucoesUso)
        {
            List<TOProgramas> listaDosProgramas = new List<TOProgramas>();

            //Adiciona o novo item na lista de programas
            listaDosProgramas.Add(new TOProgramas
            {
                Programa = nomePrograma,
                Descricao = descricao,
                Tempo = tempo,
                Potencia = potencia,
                InstrucoesUso = instrucoesUso
            });
        }
    }
}
