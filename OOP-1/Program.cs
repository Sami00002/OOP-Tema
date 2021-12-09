using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Number = Int32.Parse(Console.ReadLine());

            int[] vector = ArrayHelper.Fibonacci(Number);

            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i] + " ");
        }
    }
}
