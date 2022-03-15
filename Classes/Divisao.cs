using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudos
{
    public class Divisao : Calculobase
    {
        public override double Resultado()
        {
            double divisaoTotal = 0;

            for (int i = 0; i < Numeros.Count; i++)
            {
                divisaoTotal /= Numeros[i];
            }

            return divisaoTotal;
        }
    }
}
