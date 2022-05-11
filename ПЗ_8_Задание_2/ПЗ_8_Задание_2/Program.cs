using System;

namespace ПЗ_8_Задание_2
{
    class Program
    {
        delegate void myDelegate(char A);

        class myClass
        {
            public char i;
            public void indexFirst(char b)
            {
                i = b;
            }
        }
        static void Main(string[] args)
        {
            var cell = new myClass[5];
            for (int h = 0; h < cell.Length; h++)
            {
                cell[h] = new myClass();
                myDelegate twelw = new myDelegate(cell[h].indexFirst);
                twelw('u');
            }


            for (int h = 0; h < cell.Length; h++)
            {
                Console.WriteLine(cell[h].i);
            }
        }
    }
}
