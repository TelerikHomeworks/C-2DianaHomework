//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements (n = )");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter m = ");
        int m = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int max = -2147483648;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter aaray[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (max < array[j])
                {
                    max = array[j];
                    index = j;
                }
            }
            Console.Write(" {0}  ", array[index]);
            array[index] = -2147483648;
            max = -2147483648; 
        }

    }
}

