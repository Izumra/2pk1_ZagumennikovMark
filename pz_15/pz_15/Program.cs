using System;
using System.IO;
namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Files\File_1.txt", FileMode.Open,FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line;
            string maxString = "";
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Length > maxString.Length)
                {
                    maxString = line;
                }
                    
            }
            Console.WriteLine(maxString);

            reader.Close();
        }
    }
}
