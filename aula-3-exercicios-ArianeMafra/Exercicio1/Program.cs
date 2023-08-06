using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            bool entrada = int.TryParse(Console.ReadLine(), out int numero);
            
            if (entrada)
            {
                Console.WriteLine(VerificaTriangular(numero));
            } 
            else
            {
                Console.WriteLine($"Entrada de dado inválida!");
            }
        }

        static string VerificaTriangular(int numero)
        {
            for (int i = 1; i * (i + 1) * (i + 2) <= numero; i++)
            {
                if (i * (i + 1) * (i + 2) == numero)
                {
                    return $"O número {numero} é triangular.";
                }
            }
            return $"O número {numero} NÃO é triangular.";
        }
    }
    
}
