//https://www.beecrowd.com.br/judge/pt/problems/view/1153

using System;

public class Program
{

    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int fatorial = 1;

        for (int i = n; i > 0; i--)
        {
            fatorial *= i;
        }

        Console.WriteLine(fatorial);

    }

}