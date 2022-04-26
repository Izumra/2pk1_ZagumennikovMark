using System;

namespace delegata
{
    class Program
{
    delegate int myDelegate(char A, string B);
    static int countSymbols(char b,string a)
    {
            int g = 0;
            char[] mas = a.ToCharArray();
            for (int i=0; i<mas.Length;i++)
            {
                if (mas[i] == b) g++;
            }
            return g;
    }
    static int indexFirst(char b, string a)
    {
            return a.IndexOf(b);
    }
    static void Main(string[] args)
    {
            myDelegate first = new myDelegate(countSymbols);
            Console.WriteLine(first('u', "Purple"));
            myDelegate twelw = new myDelegate(indexFirst);
            Console.WriteLine(twelw('u', "Purple"));
        }
}
}
