//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array

using System;
class Workdays
{
    
   static int DaysBetween(DateTime d1, DateTime d2)
    {
        TimeSpan span = d2.Subtract(d1);
        return (int)span.TotalDays;
    }

   static int CountDays(DayOfWeek day, DateTime start, DateTime end)
   {
       TimeSpan ts = end - start;                       
       int count = (int)Math.Floor(ts.TotalDays / 7);   
       int remainder = (int)(ts.TotalDays % 7);         
       int sinceLastDay = (int)(end.DayOfWeek - day);  
       if (sinceLastDay < 0) sinceLastDay += 7;         
       return count;
   }
   static int CheckDays(DateTime d1, DateTime d2)
   {
       int count = 0;
       DateTime[] array =
       {
           new DateTime(2015,01,01),
           new DateTime(2015,03,02),
           new DateTime(2015,03,03),
           new DateTime(2015,04,10),
           new DateTime(2015,04,13),
           new DateTime(2015,05,01),
           new DateTime(2015,05,06),
           new DateTime(2015,09,21),
           new DateTime(2015,09,22),
           new DateTime(2015,12,24),
           new DateTime(2015,12,25),
           new DateTime(2015,12,31),

       };
       for(int i=0 ; i < array.Length; i++)
       {
           if (array[i] > d1 && array[i] < d2)
       {
           count++;
       }
       }
       return count;
   }

    static void Main(string[] args)
    {

        int count1Days = DaysBetween(new DateTime(2015,02,19), new DateTime(2015,04,08));
        int count2Sundays = CountDays(DayOfWeek.Sunday, new DateTime(2015,02,19), new DateTime(2015,04,08));
        int count2Saturday = CountDays(DayOfWeek.Saturday, new DateTime(2015,02,19), new DateTime(2015,04,08));
        int count3Holidays = CheckDays(new DateTime(2015,02,19), new DateTime(2015,04,08));
        Console.WriteLine(count1Days - (count2Sundays + count2Saturday + count3Holidays));
    }
}

