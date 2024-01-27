//https://www.beecrowd.com.br/judge/pt/problems/view/1181

using System;

public class Program
{

    public static void Main()
    {

        int entrada = int.Parse(Console.ReadLine());
        string tipo = Console.ReadLine();
        double valores = 0.0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                double elemento = double.Parse(Console.ReadLine());

                if (i == entrada)
                {
                    valores += elemento;
                }
            }
        }

        if (tipo == "S")
        {
            Console.WriteLine($"{valores:F1}");
        }
        else if (tipo == "M")
        {
            double media = valores / 12;
            Console.WriteLine($"{media:F1}");
        }

    }

}