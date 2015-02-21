//Write a program that finds in given array of integers a sequence of given sum S (if present).
using System;

class FindSumInArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements (n=) : ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Console.WriteLine("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());
        int sum1 = array[0];
        int index = 0;
        int count = 1;
        int countCopy = count;
        bool check = false;
        for (int i = 0; i < array.Length - 1; i++)
        {
            count = 1;
            sum1 = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                sum1 = sum1 + array[j];
                count++;
                if (sum1 == sum)
                {
                    countCopy = count;
                    index = i;
                    check = true;
                }
                else
                    if (sum1 < sum)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
            }
        }
        if (check)
        {
            for (int m = index; m < index + countCopy; m++)
            {
                if (m == index + countCopy - 1)
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
        else
        {
            Console.WriteLine("The sum doesn't present");
        }
    }
}

