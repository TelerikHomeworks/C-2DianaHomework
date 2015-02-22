using System;

class FirstLargerThanNeighbours
{
    static int GetFirstLargerThanNeighbours(int[] array)
    {
        int element = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                element = array[i];
                break;
            }
            
        }
        return element;
        
    }
    static void Main(string[] args)
    {
        int[] array = { 4, 6, 7, 3, 7, 8, 4, 5, 9, 20, 45, 12, 7 };
        int el = GetFirstLargerThanNeighbours(array);
        if (el == -1)
        {
            Console.WriteLine("Not found element");
        }
        else
        {
            Console.WriteLine(el);
        }
    }
}

