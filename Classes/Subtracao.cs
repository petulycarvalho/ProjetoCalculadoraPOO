using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudos
{
    public class Subtracao : Calculobase
    {
        public override double Resultado()
        {
            double sutracaoTotal = 0;

            for (int i = 0; i < Numeros.Count; i++)
            {
                sutracaoTotal -= Numeros[i];
            }

            return sutracaoTotal;
        }
    }
}
