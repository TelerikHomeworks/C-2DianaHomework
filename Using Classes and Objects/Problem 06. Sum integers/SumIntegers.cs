using System;

class SumIntegers
{
    static int Sum(string str)
    {
        int sum = 0;
        string[] array = str.Split(' ');
        int[] arrayInt32 = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            arrayInt32[i] = int.Parse(array[i]);
            sum = sum + arrayInt32[i];
        }
            return sum;
    }


    static void Main(string[] args)
    {
        Console.WriteLine(Sum("43 68 9 23 318"));
    }
}

