using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudos
{
    public class Adicao : Calculobase
    {
        public override double Resultado()
        {
            double adicaoTotal = 0;

            for (int i = 0; i < Numeros.Count; i++)
            {
                adicaoTotal += Numeros[i];
            }

            return adicaoTotal;
        }
    }
}
    
