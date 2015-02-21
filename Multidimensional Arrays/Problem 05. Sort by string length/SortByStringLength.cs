//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByStringLength
{


    static void Main(string[] args)
    {
        int wordMax = 0;
        string currentElement; 
        string[] arrayString = {"orange", "pineapple", "banana", "apple"};
        string[] sortStringByLength = new string[arrayString.Length];
        int[] arrayLength = new int[arrayString.Length];
        for(int i = 0; i < arrayString.Length; i++)
        {
            arrayLength[i] = arrayString[i].Length;
        }
        Array.Sort(arrayLength);
        for (int i = 0; i < arrayLength.Length; i++)
        {
            for (int j = 0; j < arrayString.Length; j++)
            {
                if (arrayLength[i] == arrayString[j].Length)
                {
                    
                    sortStringByLength[i] = arrayString[j];
                    arrayString[j] = "";
                    break;
                }
            }
        }
        foreach (string word in sortStringByLength)
        {
            Console.WriteLine(word);
        }

    }
}

