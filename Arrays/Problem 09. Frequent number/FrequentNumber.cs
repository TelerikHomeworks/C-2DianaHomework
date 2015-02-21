//Write a program that finds the most frequent number in an array.
using System;

class FrequentNumber
{
    static void Main(string[] args)
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int count = 1;
        int maxEl = array[0];
        int index = 0;
        int element;
        int maxCount = 1;
        
 
        for (int i = 0; i < array.Length - 1; i++)
        {
            count = 1; 
            element = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (element == array[j])
                {
                    count++;
                }
            }
            if (maxCount < count)
            {
                maxEl = array[i];
                maxCount = count;
            }
        }
        Console.WriteLine("{0} ({1} times)", maxEl, maxCount);
    }
}

