using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            bool entrada1 = int.TryParse(Console.ReadLine(), out int n1);

            Console.Write("Digite o primeiro número: ");
            bool entrada2 = int.TryParse(Console.ReadLine(), out int n2);

            if ((entrada1 && entrada2) && (n1 > 0) && (n2 > 0))
            {
                Console.WriteLine($"A multiplicação de {n1} por {n2} é igual a {Multiplicar(n1, n2)}.");
                Console.WriteLine($"A divisão inteira de {n1} por {n2} é igual a {Dividir(n1, n2)}.");
            }
            else
            {
                Console.WriteLine("Entrada de dados inválida! Entre com dois números inteiros maiores que zero.");
            }
        }

        private static int Dividir(int n1, int n2)
        {
            int resultado = 0;

            while (n1 >= n2)
            {
                n1 -= n2;
                resultado += 1;
            }

            return resultado;
        }

        private static int Multiplicar(int n1, int n2)
        {
            int resultado = 0;
            for (int i = 1; i <= n2; i++)
            {
                resultado += n1;
            }

            return resultado;
        }
   
    }
}
