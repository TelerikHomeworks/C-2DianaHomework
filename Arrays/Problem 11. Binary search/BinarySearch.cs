//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        int[] array = { 2, 6, 12, 45, 38, 69, 50 };
        int min = 0;
        int max = array.Length - 1;
        Console.WriteLine("Enter your search element: ");
        int key = int.Parse(Console.ReadLine());
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (array[mid] == key)
            {
                Console.WriteLine("Index of the number '{0}' in the array is {1}", key, mid);
                break;
            }
            else
                if (array[mid] < key)
                {
                    min += 1;
                }
                else
                {
                    max -= 1;
                }

        }
    }
}

