using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string v = Console.ReadLine();
           
            static string Hope(string v)
            {
                int i = 0;
                int k = 1;
                int p = 0;
                int u = 0;
                char[] array = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '_' };
                string r = "";
                r = v;
                if (r.IndexOfAny(array) == i)
                {
                    p++;
                    r = v.Substring(k);

                }
                else u++;
                if (p == v.Length-1)
                {
                    return "Индентификатор";
                }
                if (u>0)
                {
                    return "Не индентификатор";
                }
                return Hope(r);
            }
            Console.WriteLine(Hope(v));
        }
    }
}
