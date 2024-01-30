//https://www.beecrowd.com.br/judge/pt/problems/view/1041
//essa resposta tem MUITAS, MUITAS possibilidades de melhora.

using System;

public class Program
{

    public static void Main()
    {

        string[] entrada = Console.ReadLine().Split(' ');

        float x = float.Parse(entrada[0]);
        float y = float.Parse(entrada[1]);


        if (x == 0.0 && y == 0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0.0 && y != 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0.0 && x != 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x > 0.0 && y > 0.0)
        {
            Console.WriteLine("Q1");
        }
        else if (x > 0.0 && y < 0.0)
        {
            Console.WriteLine("Q4");
        }
        else if (x < 0.0 && y > 0.0)
        {
            Console.WriteLine("Q2");
        }
        else if (x < 0.0 && y < 0.0)
        {
            Console.WriteLine("Q3");
        }

    }

}