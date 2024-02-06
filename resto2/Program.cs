//https://www.beecrowd.com.br/judge/pt/problems/view/1075

using System;

public class Program
{
    public static void Main()
    {

        int divisor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10000; i++)
        {
            if (i % divisor == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
