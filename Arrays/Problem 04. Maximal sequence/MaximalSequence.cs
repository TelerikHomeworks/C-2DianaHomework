//Write a program that finds the maximal sequence of equal elements in an array
using System;

class MaximalSequence
{
    static void Main(string[] args)
    {
        int max = 1;
        int element;
        int count;
        int index = 0;
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        for (int i = 0; i < array.Length - 1; i++)
        {
            count = 1;
            element = array[i];
            int j = i + 1;
            while (array[j] == element)
            {
                count++;
                j++;
                if (j < array.Length)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            if (max < count)
            {
                max = count;
                index = i;
            }
        }
        if (max > 1)
        {
            for (int m = index; m < index + max; m++)
            {
                if (m == index + max - 1)
                {
                    Console.Write(array[m]);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(array[m] + ",  ");
                }
            }
        }
    }
}


