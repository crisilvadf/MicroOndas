using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neMicroOndas
{
    public class ValidaTempo
    {
        public string tempoCozimento(string tempo)
        {
            var retorno = "";

            //Verifica se o tempo de aquecimento informado está entre os valores definidos
            if (tempo != "")
                if (int.Parse(tempo) < 1 || int.Parse(tempo) > 120)
                    retorno = "O tempo de cozimento deve estar entre 1 e 120 segundos! Favor ajustar o tempo de cozimento!";

            //Verifica se foi informado algum valor de tempo
            if (tempo == "")
                retorno = "Antes de iniciar o aquecimento, favor definir um tempo de cozimento!";

            return retorno;
        }
    }
}
