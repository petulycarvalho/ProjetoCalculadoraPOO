using System;

namespace ProjetoEstudos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcaoUsuario = Menu();
            switch (opcaoUsuario)
            {
                case 1:
                    Adicao();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;

                default:
                    break;
            }
        }

        static void Adicao()
        {
            Adicao adicao = new Adicao();
            
            Console.WriteLine("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            adicao.Numeros.Add(n1);
            adicao.Numeros.Add(n2);

            Console.WriteLine($"O resultado da adicao e {adicao.Resultado()}");
        }

        static void Subtracao()
        {
            Subtracao subtracao = new Subtracao();

            Console.WriteLine("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            subtracao.Numeros.Add(n1);
            subtracao.Numeros.Add(n2);

            Console.WriteLine($"O resultado da subtracao e {subtracao.Resultado()}");
        }

        static void Divisao()
        {
            Divisao divisao = new Divisao();

            Console.WriteLine("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            divisao.Numeros.Add(n1);
            divisao.Numeros.Add(n2);

            Console.WriteLine($"O resultado da divisao e {divisao.Resultado()}");
        }

        static void Multiplicacao()
        {
            Multiplicacao multiplicacao = new Multiplicacao();

            Console.WriteLine("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            multiplicacao.Numeros.Add(n1);
            multiplicacao.Numeros.Add(n2);

            Console.WriteLine($"O resultado da multiplicacao e {multiplicacao.Resultado()}");
        }

        public static int Menu()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma opcao abaixo: ");
            Console.WriteLine("[1] - ADICAO");
            Console.WriteLine("[2] - SUBTRACAO");
            Console.WriteLine("[3] - DIVISAO");
            Console.WriteLine("[4] - MULTIPLICACAO");
            
            return int.Parse(Console.ReadLine());
        }
    }
}
