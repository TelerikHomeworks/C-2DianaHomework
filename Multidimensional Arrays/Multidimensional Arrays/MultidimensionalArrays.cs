//Write a program that fills and prints a matrix of size (n, n) as shown belo

using System;

class MultidimensionalArrays
{
    static void Main()
    {
        Console.WriteLine("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n , n];
        
        for (int row = 0; row < array.GetLength(0); row++)
        {
            array[row, 0] = row + 1;
            for (int col = 0; col < array.GetLength(1) - 1; col++)
            {

                array[row, col + 1 ] = array[row, col] + n;
            }
        }
        for (int row = 0; row < array.GetLength(0); row++)
        {
            
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(string.Format("{0} ", array[row, col]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        int ii = 0;
        int jj = 1;
        int count = 0;
        int index = 1;
        int index1 = index;
        for (int i = 0; i < array.GetLength(1); i++)
        {

            
            count++;
            if (count % 2 == 0)

            {
                ii =index1 + n - 1;
                index = ii;
            }
            else
                index1 = jj;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                
                if (count % 2 != 0)
                {
                    array[j, i] = index1;

                    jj = array[j, i];
                    
                    index1++;
                }
                else
                {
                    array[j, i] = index;

                    jj = index1 + 1;
                    index--;
                    index1++;
                }
            }
        }


        for (int row = 0; row < array.GetLength(0); row++)
        {

            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(string.Format("{0} ", array[row, col]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        int count2 = 1;
        int index2 = n;
        int a = 0; 
        for (int k = 0; k < n; k++)
        {
            for (int i = index2 - 1, j = 0; i < n   && j < count2; i++, j++)
            {
                
                    a++;
                    array[i, j] = a;
                }
                count2++;
                index2--;
            }
        count2 = n - 1;
        index2 = 1;
        for (int k = 0; k < n; k++)
        {
            for (int i = 0, j = index2; i < count2 ; i++, j++)
            {
                a++;
                array[i, j] = a;
            }
            count2--;
            index2++;
        }



        for (int row = 0; row < array.GetLength(0); row++)
        {

            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(string.Format("{0} ", array[row, col]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
            
            
        



    }
}

