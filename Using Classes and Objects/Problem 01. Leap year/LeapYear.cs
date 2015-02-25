//Write a program that reads a year from the console and checks whether it is a leap one.

using System;

    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is lear year", year);
            }
            else
            {
                Console.WriteLine("{0} isn't lear year", year);
            }
        }
    }

