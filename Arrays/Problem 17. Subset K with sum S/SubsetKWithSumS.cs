//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Collections.Generic;

class SubsetKWithSumS
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k = ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter s = ");
        int s = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;
        int count = 1;
        List<int> l = new List<int>(3);
        for (int i = 0; i < array.Length; i++)
        {
            
            Console.WriteLine("array[{0}]", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < (array.Length - k) + 1; i++)
        {
            sum = array[i];
            int m = 0;
            count = 2;
            l.Add(array[i]);
            for (int j = i + 1; j < n; j++)
            {
                if (sum + array[j] < s )
                {
                    sum += array[j];
                    l.Add(array[j]);
                    count++;
                    
                }
                else
                    if (sum + array[j] == s && count == k)
                    {
                        l.Add(array[j]);
                        foreach (int el in l)
                        {
                            Console.WriteLine();
                            Console.WriteLine(el);
                        }

                    }
                   
                        
                            
                        
                   }
            for (int ii = 0; ii < l.Count; ii++)
            {
                l.RemoveAt(ii);
            }
        }

    }
}


