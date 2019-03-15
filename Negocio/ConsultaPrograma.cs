using peMicroOndas.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConsultaPrograma
    {
        /// <summary>
        /// Consulta o programa inserido na string de entrada
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        //public List<TORetorno> consultaPrograma()
        //{
        //    List<TORetorno> retorno = new List<TORetorno>();
        //    var lista = ListaProgramas();

        //    //Percorre a lista de programas para capturar os valores padrões
        //    for (int i = 0; i < lista.Count; i++)
        //    {
        //        retorno.Add(new TORetorno { Tempo = lista[i].Tempo, Potencia = lista[i].Potencia, Programa = lista[i].Programa, Descricao = lista[i].Descricao, InstrucoesUso = lista[i].InstrucoesUso });
        //    }

        //    return retorno;
        //}


        /// <summary>
        /// Consulta o programa inserido na string de entrada
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        //public List<TORetorno> retornaProgramaSelecionado(string programaSelecionado)
        //{
        //    List<TORetorno> retorno = new List<TORetorno>();
        //    var lista = ListaProgramas();
        //    string programa = programaSelecionado.ToLower();

        //    //Percorre a lista de programas para capturar os valores padrões
        //    for (int i = 0; i < lista.Count; i++)
        //    {
        //        if (lista[i].Programa.Contains(programa))
        //        {
        //            retorno.Add(new TORetorno
        //            {
        //                Tempo = lista[i].Tempo,
        //                Potencia = lista[i].Potencia,
        //                Programa = lista[i].Programa,
        //                Descricao = lista[i].Descricao,
        //                InstrucoesUso = lista[i].InstrucoesUso
        //            });
        //        }
        //    }

        //    return retorno;
        //}

        /// <summary>
        /// Cria a lista de programas utilizados
        /// </summary>
        /// <returns></returns>
        //public List<TOProgramas> ListaProgramas()
        //{
        //    List<TOProgramas> listaProgramas = new List<TOProgramas>();
        //    listaProgramas.Add(new TOProgramas { Programa = "feijao", Descricao = "Aquecer feijão", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Feijão, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "55", Potencia = "6" });
        //    listaProgramas.Add(new TOProgramas { Programa = "arroz", Descricao = "Aquecer Arroz", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Arroz, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "45", Potencia = "5" });
        //    listaProgramas.Add(new TOProgramas { Programa = "carne", Descricao = "Aquecer Carne", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Carne, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "35", Potencia = "4" });
        //    listaProgramas.Add(new TOProgramas { Programa = "leite", Descricao = "Aquecer Leite", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Leite, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "25", Potencia = "3" });
        //    listaProgramas.Add(new TOProgramas { Programa = "pao", Descricao = "Aquecer Pão", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Pão, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "15", Potencia = "2" });

        //    return listaProgramas;
        //}

        //public List<TOProgramas> AdicionarPrograma(string programa, string descricao, string tempo, string potencia, string instrucaoDeUso)
        //{
        //    List<TOProgramas> listaProgramas = new List<TOProgramas>();
        //    listaProgramas.Add(new TOProgramas { Programa = programa, Descricao = descricao, InstrucoesUso = instrucaoDeUso, Tempo = tempo, Potencia = potencia });
        
        //    return listaProgramas;
        //}
    }
}
