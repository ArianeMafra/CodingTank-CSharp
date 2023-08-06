using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            int qntPares = 0;
            int qntImpares = 0;
            int qntPositivos = 0; 
            int qntNegativos = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite no {i}º número inteiro: ");
                bool entrada = int.TryParse(Console.ReadLine(), out int numero);

                if (entrada)
                {
                    if(numero % 2 == 0)
                    {
                        qntPares++;
                    } else
                    {
                        qntImpares++;
                    }
                    
                    if(numero > 0)
                    {
                        qntPositivos++;
                    } else
                    {
                        qntNegativos++;
                    }
                } else
                {
                    Console.WriteLine("Entrada de dado inválida. Entre com um número inteiro.");
                    i--;
                }
            }

            Console.WriteLine("Você digitou:");
            Console.WriteLine($"{qntPares} números pares");
            Console.WriteLine($"{qntImpares} números ímpares");
            Console.WriteLine($"{qntPositivos} números positivos");
            Console.WriteLine($"{qntNegativos} números negativos");
        }
    }
}
