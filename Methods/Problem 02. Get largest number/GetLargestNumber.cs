using System;

class GetLargestNumber
{
    static double GetMax(double a, double b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double maxNumber = GetMax(a, b);
        Console.WriteLine(GetMax(maxNumber, c));
    }
}

