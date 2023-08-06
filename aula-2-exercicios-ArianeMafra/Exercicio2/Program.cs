using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número inteiro: ");
            bool entrada1 = int.TryParse(Console.ReadLine(), out int A);

            Console.Write("Digite o segundo número inteiro: ");
            bool entrada2 = int.TryParse(Console.ReadLine(), out int B);

            Console.Write("Digite o terceiro número inteiro: ");
            bool entrada3 = int.TryParse(Console.ReadLine(), out int C);

            Console.Write("Digite o quarto número inteiro: ");
            bool entrada4 = int.TryParse(Console.ReadLine(), out int D);

            if ((B>C) && (D>A) && (C+D)>(A+B) && C>0 && D>0 && (A%2 == 0))
            {
                Console.WriteLine($"Valores Aceitos");
            }
            else
            {
                Console.WriteLine("Valores Não Aceitos");
            }
        }
    }
}
