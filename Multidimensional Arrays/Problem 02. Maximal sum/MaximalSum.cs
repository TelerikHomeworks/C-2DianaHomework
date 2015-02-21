//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.using System;

using System;
class MaximalSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M:");
        int m = int.Parse(Console.ReadLine());
        int[ , ] array = new int[n , m];
        int value = 0;
        int sum = 0;
        int maxSum = 0;
        int indexN = 0;
        int indexM = 0;

        for (int i = 0; i < array.GetLength(0) ; i++)
        {
            
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.WriteLine("array[{0},{1}] = ", i , j);
                array[i,j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {

            for (int j = 0; j < array.GetLength(1) - 2; j++)
            {
                sum = array[i, j] + array[i, j + 1] + array[i, j + 2]
                    + array[i + 1, j] + array[i + 1, j + 1] + array[i + 1, j + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    indexM = j;
                    indexN = i;
                }
            }

        }
        Console.WriteLine();
        Console.WriteLine("max sum = " + maxSum);
        Console.WriteLine();
        Console.WriteLine(array[indexN, indexM] + ",  " + array[indexN, indexM + 1] + ",  " + array[indexN, indexM + 2]);
        Console.WriteLine(array[indexN + 1, indexM] + ",  " + array[indexN + 1, indexM + 1] + ",  " + array[indexN + 1, indexM + 2]);
    }
}

