using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[12];
            Random rnd = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= 11; i++)
            {
                massive[i] = rnd.Next(-12, 12);
                Console.WriteLine(massive[i]);
            }
            Console.WriteLine("Массив со сдвигом:");
            int[] p = new int[4] { massive[0], massive[1], massive[2], massive[3] };
            for (int j = 0; j <= 7; j++)
            {
                massive[j] = massive[j + 4];
                Console.WriteLine(massive[j]);
            }
            for (int r = 0; r <= 4; r++){Console.WriteLine(p[r]);}
        }
    }
}
