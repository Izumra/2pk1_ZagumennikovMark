using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string v = Console.ReadLine();
            int p = 0;
            char[] array = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L' ,'l', 'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R' ,'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z','z','1','2','3','4','5','6','7','8','9','_'};
            for (int i = 0; i < array.Length-1; i++)
            {

                    if (v.StartsWith('_'))
                    {
                        //if (x==0) continue;
                        Console.WriteLine("Да");
                        p++;
                    }

                    else continue;
                
            }
            if (p == 0) Console.WriteLine("Нет");
        }
    }
}
