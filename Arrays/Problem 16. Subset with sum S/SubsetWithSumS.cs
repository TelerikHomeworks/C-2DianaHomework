//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
using System;
using System.Collections.Generic;

class SubsetWithSumS
{
    static void Main(string[] args)
    {
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        Console.WriteLine("Enter sum: ");
        int nn = int.Parse(Console.ReadLine());
        bool check = false;
        int count = 1;
       
        List<int> l = new List<int>(0);
        for(int i = 1; i < array.Length; i++)
        {
            
                l.Add(array[i]);
                count++;
                for (int j = 0; j < count; j++)
                {
                    l.Add(array[i] + l[j]);
                    
                    
                }
                count = (count - 1) * 2 + 1;
            
        }
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i] == nn)
            {
                Console.WriteLine("Yes");
                check = true;
                break;
            }
        }
        if (!check)
        {
            Console.WriteLine("No");
        }
    }
}

