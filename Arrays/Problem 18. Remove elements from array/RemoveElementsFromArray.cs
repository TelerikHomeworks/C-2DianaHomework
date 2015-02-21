using System;
using System.Collections.Generic;

class RemoveElementsFromArray
{
     
       
        static int index;
        static int count;
        static int maxCount = 1; 
    static void CountElementsFromArray(List<int> l, List<int> lIndex)
    {
        for (int i = 1; i < l.Count; i++)
        {
            index = i;
            count = 1;
            int count1 = 1;
            int k;
            lIndex.Add(i);
             for (int j = i - 1; j >= 0; j--)
            {
               
            Method(j , i, l, lIndex);
             }
        }
    }

 static void Method(int j, int i ,List<int> l, List<int> lIndex )
 {

     if(j == 0)
     {
         return;
     }
    for(int k = j; k >= 0; k--)
    {
        if(l[k] > l[k - 1])
        {
            count++;
            lIndex.Add(k);
            lIndex.Add(k - 1);
        }
        else
        {
            if(maxCount < count)
            {
                maxCount++;
            }
        }


    }

 }






    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        List<int> l = new List<int>(n);
        List<int> lIndex = new List<int>(0);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Add nem elements");
            l.Add(int.Parse(Console.ReadLine()));
        }

        
            for (int j = i - 1; j >= 0; j--)
            {
                if (l[j + 1] >= l[j])
                {
                    count++;
                    lIndex.Add(j);
                }
                else 
                {
                    if(count)
                    if(j > 0)
                    {
                    j = j--; 
                    continue;
                    }
                }
           
            }

        }


    }
}

