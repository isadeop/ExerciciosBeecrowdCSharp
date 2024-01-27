using System;

public class Program
{

    public static void Main()
    {

        string[] entradas = Console.ReadLine().Split(' ');
        int portaP = int.Parse(entradas[0]);
        int portaR = int.Parse(entradas[1]);

        if (portaP == 0)
        {
            Console.WriteLine("C");
        }
        else if (portaP == 1 && portaR == 1)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine("B");
        }

    }

}