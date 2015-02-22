//Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void ReverseDigit(decimal number)
    {

        string n = Convert.ToString(number);
        char[] array = new char[n.Length];
        array = n.ToCharArray();
        Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        decimal num =(decimal)123.45;
        ReverseDigit(num);

    }
   
}

