//existem outras formas de fazer, como usando min/max etc, mas vou manter essa por enquanto
//https://www.beecrowd.com.br/judge/pt/problems/view/1042

using System;
public class Program
{

    public static void Main()
    {
        string[] entradas = Console.ReadLine().Split(' ');
        int entrada1 = int.Parse(entradas[0]);
        int entrada2 = int.Parse(entradas[1]);
        int entrada3 = int.Parse(entradas[2]);

        if (entrada1 < entrada2 && entrada1 < entrada3)
        {
            Console.WriteLine($"{entrada1}");

            if (entrada2 < entrada3)
            {
                Console.WriteLine($"{entrada2}");
                Console.WriteLine($"{entrada3}");
            }
            else
            {
                Console.WriteLine($"{entrada3}");
                Console.WriteLine($"{entrada2}");
            }
        }

        if (entrada2 < entrada3 && entrada2 < entrada1)
        {
            Console.WriteLine($"{entrada2}");
            if (entrada3 < entrada1)
            {
                Console.WriteLine($"{entrada3}");
                Console.WriteLine($"{entrada1}");
            }
            else
            {
                Console.WriteLine($"{entrada1}");
                Console.WriteLine($"{entrada3}");
            }

        }

        if (entrada3 < entrada1 && entrada3 < entrada2)
        {
            Console.WriteLine($"{entrada3}");
            if (entrada2 < entrada1)
            {
                Console.WriteLine($"{entrada2}");
                Console.WriteLine($"{entrada1}");

            }
            else
            {
                Console.WriteLine($"{entrada1}");
                Console.WriteLine($"{entrada2}");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"{entrada1}");
        Console.WriteLine($"{entrada2}");
        Console.WriteLine($"{entrada3}");

    }
}