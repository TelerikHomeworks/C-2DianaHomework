//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SequenceNMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        string[,] array = new string[n, m];
        int count = 0;
        int maxCount = 0;
        string word = "";
        string maxWord = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.WriteLine("array[{0} , {1}] = ", i, j);
                array[i, j] = Console.ReadLine();
            }
        }

        for (int i = 0; i < array.GetLength(1); i++)
        {
            count = 0;
            for (int j = 0; j < array.GetLength(0) - 1; j++)
            {
                if (string.Equals(array[j, i], array[j + 1, i]))
                {
                    count++;
                    word = array[j, i];

                }
                else
                {
                    break;
                }

            }
            if (maxCount < count)
            {
                maxCount = count;
                maxWord = word;
            }

        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            count = 0;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (string.Equals(array[i, j], array[i, j + 1]))
                {
                    count++;
                    word = array[i, j];
                }
                else
                {
                    break;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
                maxWord = word;
            }
        }


        for (int i = 0, j = 0; i < n; i++)
        {
            count = 0;
            for (int ii = i, jj = 0; ii < n - 1 && jj < n - 1; ii++, jj++)
            {
                if (string.Equals(array[ii, jj], array[ii + 1, jj + 1]))
                {
                    count++;
                    word = array[ii, jj];
                }
                else
                {
                    break;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
                maxWord = word;
            }

        }

        for (int j = 0, i = 1; j < n; j++)
        {
            count = 0;
            for (int jj = j, ii = 1; jj < n - 1; ii++, jj++)
            {
                if (string.Equals(array[ii, jj], array[ii + 1, jj + 1]))
                {
                    count++;
                    word = array[ii, jj];
                }
                else
                {
                    break;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
                maxWord = word;
            }
        }

        for (int i = 0, j = m - 1; i < n; i++)
        {
            count = 0;
            for (int ii = i, jj = m - 1; ii < n - 1; ii++, jj--)
            {
                if (string.Equals(array[ii, jj], array[ii + 1, jj - 1]))
                {
                    count++;
                    word = array[ii, jj];
                }
                else
                {
                    break;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
                maxWord = word;
            }
        }

        for (int i = 0, j = 0; j < m - 1; j++)
        {
            count = 0;
            for (int ii = 0, jj = j; jj >= 1; ii++, jj--)
            {
                if (string.Equals(array[ii, jj], array[ii + 1, jj - 1]))
                {
                    count++;
                    word = array[ii, jj];
                }

            }
            if (maxCount < count)
            {
                maxCount = count;
                maxWord = word;
            }
        }
        for (int i = 0; i < maxCount + 1; i++)
        {
            Console.Write(maxWord + "  ");
        }
    }
}
