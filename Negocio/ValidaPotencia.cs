using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neMicroOndas
{
    public class ValidaPotencia
    {
        public string potenciaAquecimento(string potencia)
        {
            var retorno = "";

            //Verifica se foi definido um valor de potência
            if (potencia != "")
                if (int.Parse(potencia) < 1 || int.Parse(potencia) > 10)
                    retorno = "A potencia deve estar entre 1 e 10! Favor ajustar a potência!";
            return retorno;
        }
    }
}
