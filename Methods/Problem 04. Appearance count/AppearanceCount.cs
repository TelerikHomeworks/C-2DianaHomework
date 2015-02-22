//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static int CountNumberInArray(int num, int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        int number = 3;
        int[] array = {4, 5, 3, 6, 7, 8, 3 , 7, 8 , 3, 5, 3, 8, 3};
        int count = CountNumberInArray(number, array);
        Console.WriteLine("The number {0} is appeared in given array {1} times", number, count);
    }
}

