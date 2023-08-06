using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número inteiro: ");
            bool entrada1 = int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Digite o segundo número inteiro: ");
            bool entrada2 = int.TryParse(Console.ReadLine(), out int num2);

            if (entrada1 && entrada2)
            {
                int soma = num1 + num2;
                Console.WriteLine($"O resultado da soma de {num1} e {num2} é {soma}");
            } else
            {
                Console.WriteLine("Entrada de dados inválida! Tente novamente inserindo dois números inteiros.");
            }
        }
    }
}
