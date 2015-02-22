//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;

class NumberAsArray

{
    static int AddsTwoPositiveIntegerNumbers(string[] num1, string[] num2)
    {
        int sum = 0;
        Array.Reverse(num1);
        Array.Reverse(num2);
        string n1 = "";
        string n2 = "";
        for (int i = 0; i < num1.Length; i++)
        {
            n1 = n1 + num1[i];
        }
        for (int i = 0; i < num2.Length; i++)
        {
            n2 = n2 + num2[i];
        }

        int nn1 = int.Parse(n1);
        int nn2 = int.Parse(n2);
        
            return nn1 + nn2; 
    }

    
    static void Main(string[] args)
    {
        string[] number1 = { "3", "4", "1" };
        string[] number2 = { "1", "2", "9" };
        Console.WriteLine(AddsTwoPositiveIntegerNumbers(number1, number2));
    }
}

