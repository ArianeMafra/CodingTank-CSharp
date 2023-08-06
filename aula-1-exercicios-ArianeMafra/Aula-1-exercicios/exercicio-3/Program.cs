class Exercicio3
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        Console.WriteLine($"A frase digitada foi: {frase}.");
        Console.WriteLine($"A frase contem {frase.Length} caracteres.");
    }
}