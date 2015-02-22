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
                binarySystem.Add(num % 16);
                num = num / 16;
            }
            binarySystem.Reverse();
            string st = "";
            foreach (int a in binarySystem)
            {

                if (a == 10 || a == 11 || a == 12 || a == 13 || a == 14 || a == 15)
                {
                    switch (a)
                    {
                        case 10:
                            st = "A";
                            break;
                        case 11:
                            st = "B";
                            break;
                        case 12:
                            st = "C";
                            break;
                        case 13:
                            st = "D";
                            break;
                        case 14:
                            st = "E";
                            break;
                        case 15:
                            st = "F";
                            break;
                    }
                    Console.Write(st);
                }
                else
                {
                    Console.Write(a);
                }
            }
            Console.WriteLine();
        }
    }

