using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public class TempoCozimento
    {
        public void tempoCozimento(DateTime tempo)
        {
            if (tempo != null)
            {
                var tmp = tempo.Minute * 60 + tempo.Second;
                if (tmp > 120)
                {
                    throw new Exception("O tempo não pode ser maior que 2 minutos");
                }
            }
        }
    }
}
