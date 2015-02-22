//Write a program to calculate n! for each n in the range [1..100].

using System;
   class NFactorial
    {
       static int Factorial(int n)
       {
           int f = 1; 
           if (n == 1)
               return 1;
           else
           {
               for (int i = 1; i <= n; i++)
               {
                   f = f * i;
               }
           return f;
           }
       }
        static void Main(string[] args)
        {
            int num = 7;
            Console.WriteLine(Factorial(num));
        }
    }

