class Exercicio2
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em metros: ");
        float altura = float.Parse(Console.ReadLine());

        Console.Write("Digite seu peso em kilos: ");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine($"Nome: {nome} \nIdade: {idade} anos \nAltura: {altura} m \nPeso: {peso} Kg");
    }
}