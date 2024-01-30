//https://www.beecrowd.com.br/judge/pt/problems/view/2242

using System;

public class Program
{

    public static void Main()
    {

        string entrada = Console.ReadLine();
        string vogais = "";
        string vogaisInvertidas = "";

        for (int i = 0; i < entrada.Length; i++)
        {
            switch (entrada[i])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    vogais += entrada[i];
                    break;
            }
        }

        for (int j = vogais.Length - 1; j >= 0; j--)
        {
            vogaisInvertidas += vogais[j];
        }

        if (vogais == vogaisInvertidas)
        {
            Console.WriteLine("S");
        }
        else
        {
            Console.WriteLine("N");
        }
    }
}