//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        int[] array = { 5, 10, 3, 4, 14, 23, 7, 4, 5, 8, 12 };
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int a = array[i];
                    array[i] = array[j];
                    array[j] = a;
                }
            }
        }

        string arrayPrint = string.Join(", ", array);
        Console.WriteLine(arrayPrint);
    }
}

