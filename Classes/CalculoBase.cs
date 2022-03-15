using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudos
{
    public abstract class Calculobase
    {
        public Calculobase()
        {
            Numeros = new List<double>();
        }

        public List<double> Numeros { get; set; }

        public abstract double Resultado();
    }
}
