//https://www.beecrowd.com.br/judge/pt/problems/view/1042

using System;

public class Program
{
    public static void Main()
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);


        int menor = Math.Min(Math.Min(a, b), c);
        int maior = Math.Max(Math.Max(a, b), c);
        int meio;

        if (a != maior && a != menor)
        {
            meio = a;
        }
        else if (b != menor && b != maior)
        {
            meio = b;
        }
        else
        {
            meio = c;
        }

        Console.WriteLine(menor);
        Console.WriteLine(meio);
        Console.WriteLine(maior);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

    }
}