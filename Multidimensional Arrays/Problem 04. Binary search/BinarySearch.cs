//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;


class BinaySearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter k = ");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());

        }
        int index = 0;
        int indexMax = - 1;
        Array.Sort(array);

        if (array[0] > k)
        {
            Console.WriteLine("there isn't any numbers that is < ot = to k");
        }
        else
        {
            if (Array.BinarySearch(array, k) >= 0)
            {
                Console.WriteLine(array[Array.BinarySearch(array, k)]);
            }
            else
            {
                while (Array.BinarySearch(array, k) < 0)
                {
                    k--;
                }
                Console.WriteLine(k);
            }

        }



        
           
    }
}

