﻿using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cate numere sa fie din sirul fibonacci?");
            int Number;
            Number = Int32.Parse(Console.ReadLine());

            int[] vector = ArrayHelper.Fibonacci(Number);

            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i] + " ");
            { 
                Console.Write("\n Cate numeri vrei sa citesti de la tastatura?");
                int[] Frequencies = ArrayHelper.Identitate(10);

                for (int j = 0; j < Frequencies.Length; j++)
                {
                    Console.Write("The " + (j + 1) + ". element appears ");
                    Console.WriteLine(Frequencies[j] + " times");
                }
            }

                Console.WriteLine("\n Introduceti numarul de linii din matrice!");

                int n1 = Int32.Parse(Console.ReadLine());
                int[,] matrix = new int[n1, n1];
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write($"matrix[{row},{col}]:");
                        matrix[row, col] = Int32.Parse(Console.ReadLine());

                    }
                }
                if (ArrayHelper.Identitate(matrix) == true)
                    Console.WriteLine("Este matrice identitate!");
                else
                    Console.WriteLine("Nu este matrice identitate!");

            
        }
    }
}
