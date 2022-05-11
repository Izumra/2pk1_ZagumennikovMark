using System;

namespace ПЗ_9_События
{
    class Program
    {
        static void Main(string[] args)
        {
            Posetitel ss = new Posetitel();
            Handler hand = new Handler();
            ss.onCount += hand.Message;
            ss.Count();
        }
    }
}
