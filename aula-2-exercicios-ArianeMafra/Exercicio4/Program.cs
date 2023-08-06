using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do aluno: ");
            bool entrada = double.TryParse(Console.ReadLine(), out double nota);
            nota.ToString("F2");

            string conceito;

            if (nota >= 8.00 && nota <= 10.00)
            {
                conceito = "Ótimo";
            }
            else if (nota >= 6.00 && nota <= 7.99)
            {
                conceito = "Bom";
            }
            else if (nota >= 4.00 && nota <= 5.99)
            {
                conceito = "Regular";
            }
            else if (nota >= 0.00 && nota <= 3.99)
            {
                conceito = "Péssimo";
            }
            else
            {
                conceito = "Nota inválida";
            }

            Console.WriteLine($"Conceito: {conceito}.");
            
        }
    }
}
