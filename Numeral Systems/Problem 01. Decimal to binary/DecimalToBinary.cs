//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number in decimal numeral system");
            int num = int.Parse(Console.ReadLine());
            List<int> binarySystem = new List<int>();
            while (num > 0)
            {
                binarySystem.Add(num % 2);
                num = num / 2;
            }
            binarySystem.Reverse();
            foreach (int a in binarySystem)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }

