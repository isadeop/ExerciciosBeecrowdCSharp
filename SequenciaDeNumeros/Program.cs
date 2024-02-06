// https://www.beecrowd.com.br/judge/pt/problems/view/1101

using System;

class URI
{

    static void Main(string[] args)
    {
        while (true)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int m = int.Parse(entrada[0]);
            int n = int.Parse(entrada[1]);

            if (m <= 0 || n <= 0)
            {
                break;
            }

            int menor = Math.Min(m, n);
            int maior = Math.Max(m, n);
            int sum = 0;

            for (int i = menor; i <= maior; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine($"Sum={sum}");
        }
    }
}