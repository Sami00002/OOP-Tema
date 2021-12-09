using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class ArrayHelper
    {
        public static int[] Fibonacci(int Number)
        {
            int nrElement = 1;

            int[] Vector = new int[Number];
            {
                int fib1 = 1;
                int fib2 = 1;
                int fib3 = fib1 + fib2;
                while (nrElement < Number)
                {
                    Vector[nrElement] = fib1;

                    nrElement++;

                  


                    fib1 = fib2;
                    fib2 = fib3;
                    fib3 = fib1 + fib2;
                }
            }
            return Vector;
        }
    }
}
