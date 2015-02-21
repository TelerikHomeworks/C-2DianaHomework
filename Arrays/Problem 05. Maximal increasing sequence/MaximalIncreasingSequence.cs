//Write a program that finds the maximal increasing sequence in an array.

using System;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {

        int max = 1;
        int element;
        int count;
        int index = 0;
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        for (int i = 0; i < array.Length - 1; i++)
        {
            count = 1;
            element = array[i];
            int j = i + 1;
            while (array[j] == array[j - 1] + 1)
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

