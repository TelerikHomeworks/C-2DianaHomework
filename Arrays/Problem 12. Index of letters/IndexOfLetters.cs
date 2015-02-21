//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array
using System;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        char c;

        char[] arrayAlphabet = new char[26];
        for (int i = 0, j = 65; i < arrayAlphabet.Length; i++, j++)
        {
            arrayAlphabet[i] = (char)j;
        }
        Console.WriteLine("Enter word with uppercase letters: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < arrayAlphabet.Length; j++)
            {
                if (word[i] == arrayAlphabet[j])
                {
                    Console.Write(j + "  ");
                    break;
                }
            }
        }
    }
}

