using System.Collections;
using System.Collections.Generic;
using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] massive = new int[8][];
            int[] massive2 = new int[8];
            int[] massive3 = new int[8];
            int n = 0;
            Random rnd = new Random();
            Random Rnd = new Random();
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i <8; i++)
            {
                massive[i] = new int[rnd.Next(6, 10)];
                for (int y=0;y<massive[i].Length;y++)
                {
                    massive[i][y] = Rnd.Next(0,20);
                }
                int u = Max(massive[i]);
                massive3[i] = u;
                
                for (int c = 0; c < massive[i].Length; c++)
                {
                    Console.Write($"{massive[i][c]}"+", ");       
                    if (c == massive[i].Length-1)
                    {
                        Console.WriteLine();
                        massive2[n]= massive[i][c];
                        n++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ступенчатый массив с замененными элементами: ");
            for (int m=0; m<8;m++)
            {

                for (int e = 0; e < massive[m].Length - 1; e++)
                {
                    int l = massive[m][0];
                    int c = massive[m][massive[m].Length - 1];
                    massive[m][0] = c;
                    massive[m][massive[m].Length-1] = l;
                    //if (e == massive[m].Length-1 ) massive[m].Add(massive[m].Length - 1);
                    //if(e==0)
                    Console.Write($"{massive[m][e]}" + ", ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            //2 часть задания
            Console.WriteLine("Массив последних элементов: ");
            for (int u=0;u<massive2.Length;u++)
            {
                Console.Write($"{massive2[u]}" + ", ");
            }
            Console.WriteLine();
            //3 часть задания
            Console.WriteLine("Массив максимальных элементов: ");
            for (int q = 0; q < massive3.Length; q++)
            {
                Console.Write($"{massive3[q]}" + ", ");
            }
        }
        static int Max(int[] array) 
        {
            int max = array[0];        
            for (int i = 0; i < array.Length; i++) 
            {
                if (max < array[i])    
                {
                    max = array[i];  
                }
            }
            return max;    
        }
    }
}
