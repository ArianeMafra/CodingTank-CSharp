using System.Formats.Asn1;

class Exercicio4
{
    static void Main()
    {
        Console.Write("Digite o raio do círculo: ");
        float raio = float.Parse(Console.ReadLine());

        Console.WriteLine($"A área do círculo é {CalculaAreaCirculo(raio).ToString("F2")}.");
    }

    private static float CalculaAreaCirculo(float raio)
    {
        return ((float)(Math.PI * raio * raio));
    }
}