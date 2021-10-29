using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] massive = new int[7,7];
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    massive[i, j] = rnd.Next(-10, 10);
                    Console.Write($"{massive[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Главная диагональ");
            int o = 0;
            int plus = 0;
            for (int k = 0; k <7;k++)
            {
                if (massive[k, o] > 0)
                {
                    plus++;
                }
                Console.Write($"{massive[k, o]}"+",");
                o++;
            }
            Console.WriteLine();
            Console.WriteLine("Количество положительных чисел в главной диагонали: "+$"{plus}");
        }
    }
}
