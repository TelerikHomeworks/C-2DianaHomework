using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        DateTime dayOfWeek = DateTime.Now;
        string today = "dddd";
        Console.WriteLine(dayOfWeek.ToString(today));
    }
}

