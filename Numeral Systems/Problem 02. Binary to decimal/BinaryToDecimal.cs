using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static int ConvertBinaryToDecimal(string num)
    {
        List<int> array = new List<int>();
        for (int i = 0; i < num.Length; i++)
        {
            string a = num[i].ToString();
            array.Add(int.Parse(a));
        }
        array.Reverse();
        int el;
        int decimalNumeralSystems = 0;
        for (int i = 0; i < array.Count; i++)
        {
            el = array[i];
            for (int j = 1; j <= i; j++)
            {
                el = el * 2;
            }
            decimalNumeralSystems += el;
        }
        return decimalNumeralSystems;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number in binary numeral system");
        string num =Console.ReadLine();
        

        Console.WriteLine(ConvertBinaryToDecimal(num));

    }
}

