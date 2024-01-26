//https://www.beecrowd.com.br/judge/pt/problems/view/1064

using System;

public class Program
{
    public static void Main()
    {
        double quantiaDePositivos = 0;
        double valorTotal = 0;

        for (int i = 0; i < 6; i++)
        {
            double entrada = double.Parse(Console.ReadLine());

            if (entrada > 0)
            {
                quantiaDePositivos++;
                valorTotal += entrada;
            }
        }

        double media = valorTotal / quantiaDePositivos;

        Console.WriteLine($"{quantiaDePositivos} valores positivos");
        Console.WriteLine($"{media:F1}");
    }

}