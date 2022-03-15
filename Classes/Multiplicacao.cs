using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudos
{
    public class Multiplicacao : Calculobase
    {
        public override double Resultado()
        {
            double multiplicacaoTotal = 0;

            for (int i = 0; i < Numeros.Count; i++)
            {
                multiplicacaoTotal *= Numeros[i];
            }

            return multiplicacaoTotal;
        }
    }
}
