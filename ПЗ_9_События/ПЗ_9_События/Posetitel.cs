using System;
using System.Collections.Generic;
using System.Text;

namespace ПЗ_9_События
{
    class Posetitel
    {

        public delegate void MethodContainer();
        public event MethodContainer onCount;
        public void Count()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i == 30)
                {
                    onCount();
                }
            }

        }
    }
}
