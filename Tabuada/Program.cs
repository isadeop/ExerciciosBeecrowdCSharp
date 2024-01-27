// https://www.beecrowd.com.br/judge/pt/problems/view/1078

using System;

public class Program
{

    static void Main()
    {

        int entradaN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {

            int tabuada = i * entradaN;

            Console.WriteLine($"{i} x {entradaN} = {tabuada}");
        }

    }

}