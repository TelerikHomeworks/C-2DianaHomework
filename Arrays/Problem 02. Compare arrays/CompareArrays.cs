//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements");
        int number = int.Parse(Console.ReadLine()); 
        int[] array1 = new int[number];
        int[] array2 = new int[number];
        bool check = true;
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Enter array1[{0}] = ", i);
            array1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine("Enter array2[{0}] = ", i);
            array2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < number; i++)
        {
            if (array1[i] != array2[i])
            {
                check = false;
                break;
            }
        }
        if (check)
        {
            Console.WriteLine("Two Arrays are equal");
        }
        else
        {
            Console.WriteLine("Two Arrays aren't equal");
        }
    }
}

