using System;

namespace Pz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] values = text.Split(new char[] { ' ' });
            for (int i = 0; i < values.Length; i++)
            {
                try
                {
                    if (Convert.ToInt32(values[i]) == 0||0 / Convert.ToInt32(values[i]) == 0)
                    {
                        Console.WriteLine(Convert.ToInt32(values[i]));
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
