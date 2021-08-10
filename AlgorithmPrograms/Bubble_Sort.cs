using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Bubble_Sort
    {
        public void BubbleSort()
        {
            int[] list = { 2, 4, 6, 8, 7, 5, 3, 1 };
            Console.Write("\nBefore Bubble sort is: ");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i].CompareTo(list[j]) > 0)
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            Console.Write("\nAfter Bubble sort is: ");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
