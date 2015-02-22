//Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static string GetLastDigitAsAEnglishWord(int number)
    {
        int lastDigit = number % 10;
        string digit = "";
        switch (lastDigit)
        {
            case 1:
                digit = "one";
                break;
            case 2:
                digit = "two";
                break;
            case 3:
                digit = "three";
                break;
            case 4:
                digit = "four";
                break;
            case 5:
                digit = "five";
                break;
            case 6:
                digit = "six";
                break;
            case 7:
                digit = "seven";
                break;
            case 8:
                digit = "eight";
                break;
            case 9:
                digit = "nine";
                break;
            case 0:
                digit = "zero";
                break;
                
        }
        return digit;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        string lastDigit = GetLastDigitAsAEnglishWord(number);
        Console.WriteLine(lastDigit);
    }
}

