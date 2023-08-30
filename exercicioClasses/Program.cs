using exercicioClasses;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1, p2;

        p1 = new Pessoa();
        p2 = new Pessoa();

        Console.WriteLine("Coloque o nome e idade de duas pessoas:");
        Console.WriteLine("Primeira pessoa: ");
        p1.nome = Console.ReadLine();
        p1.idade = int.Parse(Console.ReadLine());

        Console.WriteLine("segunda pessoa:");
        p2.nome = Console.ReadLine();
        p2.idade = int.Parse(Console.ReadLine());

        if (p1.idade > p2.idade)
            Console.WriteLine(p1.nome + " é mais velho(a)");
        else
            Console.WriteLine(p2.nome + " é mais velho(a)");
    }
}