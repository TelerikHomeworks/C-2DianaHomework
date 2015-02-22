//Write a program to convert hexadecimal numbers to their decimal representation

using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static int ConvertHexadecimalToDecimal(string num)
    {
        List<int> array = new List<int>();
        for (int i = 0; i < num.Length; i++)
        {
            string a = num[i].ToString();

            if (a == "A" || a == "B" || a == "C" || a == "D" || a == "E" || a == "F")
            {
                switch (a)
                {
                    case "A":
                        a = "10";
                        break;
                    case "B":
                        a = "11";
                        break;
                    case "C":
                        a = "12";
                        break;
                    case "D":
                        a = "13";
                        break;
                    case "E":
                        a = "14";
                        break;
                    case "F":
                        a = "15";
                        break;
                }


            }
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
                    el = el * 16;
                }
                decimalNumeralSystems += el;
            }
            return decimalNumeralSystems;
        }
    
    static void Main(string[] args)
    {
        Console.WriteLine(ConvertHexadecimalToDecimal("D1E"));
    }
}

