using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    class Math
    {
        public int Subtract(int x, int y)
        {
            return y - x;
        }


        public int Division(int x, int y)
        {
            int z = x / y;
            Console.WriteLine("Result of division: " + z);
            return z;
        }
    }
}
