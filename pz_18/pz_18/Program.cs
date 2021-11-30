using System;

namespace pz_18
{
    class Program
    {
        /*          1 задание
                            
        static double Kitca(double n)
        {
            if (n == 0)return n;
            return 9 + 0.5 * Kitca(n - 1);
        }
        */
        /*              2 задание
        static float NthGeomtrProg(float elem, float step, int count)
        {
            if (count == 1)
                return elem;

            float result = NthGeomtrProg(elem * step, step, count - 1);
            return result;
        }
        */
        /*              3 задание
        static void Kitct(int n, int u)
        {
            if (n < u) 
            {
                Console.WriteLine((char)u);
                Kitct(n, u-1);
               
            }
            if (n > u)
            {
                Console.WriteLine((char)u);
                Kitct(n, u+1);
                
            }
        }
        */
        /*              4 задание
        static void Kitcw(string n) 
        { 

            Console.Write(n[n.Length-1]);
            if(n.Length>1)Kitcw(n.Substring(0, n.Length-1));
            
        }
        */
        static void Main(string[] args)
        {
            //Console.Write(Kitca(5)); // 1 задание
            /*          2 задание
            float b1 = 8;
            float q = 0.3f;

            Console.Write("Введите номер члена геометрической прогрессии: ");
            int bn = int.Parse(Console.ReadLine());

            float chlen = NthGeomtrProg(b1, q, bn);
            Console.WriteLine($"{bn} член геометр. прогрессии равен {chlen}");
            */
            //Kitct(1072,1040); // 3 задание
            //Kitcw("567");     //4 задание
        }
    }
}
