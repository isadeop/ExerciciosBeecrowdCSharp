//https://www.beecrowd.com.br/judge/pt/problems/view/2399

using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        int[] celulas = new int[N];

        for (int i = 0; i < N; i++)
        {
            celulas[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            int minas = celulas[i];

            if (i < N - 1)
            {
                minas += celulas[i + 1];
            }


            if (i > 0)
            {
                minas += celulas[i - 1];
            }


            Console.WriteLine(minas);

        }

    }

}