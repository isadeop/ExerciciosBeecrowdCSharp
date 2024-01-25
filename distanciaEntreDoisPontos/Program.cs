//https://www.beecrowd.com.br/judge/pt/problems/view/1015

using System;

namespace DistanciaEntreDoisPontos_1015;

public class Program
{
    public static void Main()
    {

        string[] entradas = Console.ReadLine().Split(' ');

        double x1 = double.Parse(entradas[0]);
        double y1 = double.Parse(entradas[1]);

        entradas = Console.ReadLine().Split(' ');

        double x2 = double.Parse(entradas[0]);
        double y2 = double.Parse(entradas[1]);

        double diferencaX = x2 - x1;
        double diferencaY = y2 - y1;

        double diferencaEntrePontos = Math.Sqrt(diferencaX
            * diferencaX + diferencaY * diferencaY);

        Console.WriteLine($"{diferencaEntrePontos:F4}");

    }

}
