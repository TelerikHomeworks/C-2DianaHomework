//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
using System;

class LargerThanNeighbours
{
    static void checkElementIfIsLargerThanNeighbours(int position, int[] array)
    {
        if(position == array.Length - 1 || position == 0)
        {
            Console.WriteLine("The element has only one neighbour");
        }
        else
            if (array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                Console.WriteLine("The element is larger than its two neighbours");
            }
            else
            {
                Console.WriteLine("The element isn't larger than its two neighbours");
            }
    }


    static void Main(string[] args)
    {
        int position = 4;
        int[] array1 = { 4, 7, 8, 3, 2, 9, 0, 4, 6, 9, 0, 5, 7, 9, 30 };
        int[] array2 = { 7, 40, 50, 3, 70, 5, 6, 56, 7, 9 };
        checkElementIfIsLargerThanNeighbours(position, array1);
        checkElementIfIsLargerThanNeighbours(position, array2);
    }
}

