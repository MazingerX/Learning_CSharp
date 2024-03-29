﻿using System;

namespace Fibonacci_Sequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("To find a Fibonacci Sequence we need a Pascal Triangle:");
            Console.WriteLine("Enter how many sequence numbers you want to see in the Fibonacci sequence");

            int rowsTriangle = int.Parse(Console.ReadLine());

            // Allocate the array in a triangle form
            long[][] pascalMatrix = new long[rowsTriangle + 1][];

            for (int row = 0; row < rowsTriangle; row++)
            {
                pascalMatrix[row] = new long[row + 1];
            }

            // Calculate the Pascla's triangle
            pascalMatrix[0][0] = 1;

            for (int row = 0; row < rowsTriangle - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    pascalMatrix[row + 1][col] += pascalMatrix[row][col];
                    pascalMatrix[row + 1][col + 1] += pascalMatrix[row][col];
                }
            }

            // Print Pascal's triangle
            Console.WriteLine("This is your Pascal Triangle");
            for (int row = 0; row < rowsTriangle; row++)
            {
                Console.Write("".PadLeft((rowsTriangle - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,6}", pascalMatrix[row][col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Fibonacci calculation
            Console.WriteLine("Your Fibonacci Sequence is: ");

            Console.WriteLine();
            
            int rowsFibo = 0;
            long[] fibonacci = new long[rowsTriangle - 1];
            fibonacci[0] = 1;

            while (rowsFibo < rowsTriangle)
            {                
                for (int j = 0; j < rowsFibo; j++)
                {                    
                    if (rowsFibo - j >= j)
                    {
                        long num = pascalMatrix[rowsFibo - j][j];
                        fibonacci[j] = num;                                                
                    }                    
                }
                long fibNum = 0;
                for (int i = 0; i < rowsFibo; i++)
                {                    
                    fibNum = fibonacci[i] + fibNum;                    
                }
                Console.Write(" " + fibNum);
                rowsFibo++;
            }         
        }
    }
}

