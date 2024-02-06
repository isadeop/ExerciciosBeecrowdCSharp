//https://www.beecrowd.com.br/judge/pt/problems/view/1165

using System;
public class Program
{

    public static void Main(string[] args)
    {

        int quantCasos = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantCasos; i++)
        {
            int casoAtual = int.Parse(Console.ReadLine());
            bool ehPrimo = true;

            for (int j = casoAtual - 1; j > 1; j--)
            {
                if (casoAtual % j == 0)
                {
                    ehPrimo = false;
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine($"{casoAtual} eh primo");
            }
            else
            {
                Console.WriteLine($"{casoAtual} nao eh primo");
            }
        }

    }

}