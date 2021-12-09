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

        public static int[] Identitate(int nrElementsr)
        {
            Console.Write("Cate numeri vrei sa citesti de la tastatura?");
            int nrElements = int.Parse(Console.ReadLine());
            int[] Vector1 = new int[nrElements];
            int[] Frequencies = new int[nrElements];





            for (int i = 0; i < nrElements; i++)
            {
                Console.Write("The " + (i + 1) + ". element = ");
                Vector1[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < nrElements; i++)
            {
                Frequencies[i] = 0;
              
                for (int j = 0; j < nrElements; j++)
                    if (Vector1[i] == Vector1[j]) Frequencies[i]++;
               
            }

           

            return Frequencies;
        }
        public static bool Identitate(int[,] matrix)
        {
            bool esteIdentitate = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (row != col)
                    {
                        if (matrix[row, col] != 0)
                        {
                            esteIdentitate = false;
                        }
                    }
                    else if (matrix[row, col] != 1)
                    {
                        esteIdentitate = false;
                    }
                }
            }
            if (esteIdentitate == true)
                return true;
            else
                return false;
        }
    }
}
