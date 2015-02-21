//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());
        char[] array1 = new char[n];
        char[] array2 = new char[n];
        bool check = true;
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Enter array1[{0}] = ", i);
            array1[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine("Enter array2[{0}] = ", i);
            array2[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if ((int)array1[i] != (int)array2[i])
            {
                check = false;
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

