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


        int x = a;
        int y = b;
        int z = c;

        if (y > z)
        {
            int aux = y;
            y = z;
            z = aux;
        }

        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }

        if (y > z)
        {
            int aux = y;
            y = z;
            z = aux;
        }

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

    }
}