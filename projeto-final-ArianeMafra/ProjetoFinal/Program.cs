using System;

namespace ProjetoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] dadosPessoas = {{"Ana", "Paulo", "Márcia", "Pedro",  "Beatriz"},
                                      {"1,70", "1,72", "1,62", "1,90", "1,53" },
                                      {"80", "90", "61", "84", "49"}
            };     
            
            double somaAlturas = 0;
            double somaPesos = 0;

            double numeroPessoas = dadosPessoas.GetLength(1);

            for (int i = 0; i < numeroPessoas; i++) 
            {
                double altura = double.Parse(dadosPessoas[1,i]);
                somaAlturas += altura;
                double peso = double.Parse(dadosPessoas[2, i]);
                somaPesos += peso;
            }
            double mediaAltura = somaAlturas / numeroPessoas;
            double mediaPeso = somaPesos / numeroPessoas;

            Console.WriteLine($"A média aritmética de altura é {mediaAltura:F2} m.");
            Console.WriteLine($"A média aritmética do peso é {mediaPeso:F2} Kg.");

            string maisAlto = "";
            double maiorAltura = 0;

            string maisBaixo = "";
            double menorAltura = double.MaxValue;

            string maisPesado = "";
            double maiorPeso = 0;

            string maisLeve = "";
            double menorPeso = double.MaxValue;

            string pessoaMaiorImc = "";
            double maiorImc = 0;

            string pessoaMenorImc = "";
            double menorImc = double.MaxValue;

            for (int i = 0;i < numeroPessoas; i++)
            {
                string nome = dadosPessoas[0,i];
                double altura = double.Parse(dadosPessoas[1,i]);
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    maisAlto = nome;
                }
                if (altura < menorAltura)
                {
                    menorAltura = altura;
                    maisBaixo = nome;
                }

                double peso = double.Parse(dadosPessoas[2, i]);
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    maisPesado = nome;
                }
                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    maisLeve = nome;
                }

                double imc = peso / (altura * altura);
                if (imc > maiorImc)
                {
                    maiorImc = imc;
                    pessoaMaiorImc = nome;
                }
                if (imc < menorImc)
                {
                    menorImc = imc;
                    pessoaMenorImc = nome;
                }

                Console.WriteLine($"{nome}, IMC = {imc:F2}.");

            }

            Console.WriteLine($"{maisAlto} é a pessoa mais alta com {maiorAltura} m.");
            Console.WriteLine($"{maisBaixo} é a pessoa mais baixa com {menorAltura} m.");
            Console.WriteLine($"{maisPesado} é a pessoa mais pesada com {maiorPeso} Kg.");
            Console.WriteLine($"{maisLeve} é a pessoa mais leve com {menorPeso} Kg.");
            Console.WriteLine($"{pessoaMaiorImc} é a pessoa com maior IMC com o valor de {maiorImc:F2}.");
            Console.WriteLine($"{pessoaMenorImc} é a pessoa com menor IMC com o valor de {menorImc:F2}.");
        }
    }
}
