using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        Random randomValues = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomValues.Next(100, 200));
        }
    }
}

