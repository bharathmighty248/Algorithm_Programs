using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimePalindrome
    {
        const int RANGE = 1000;
        public void Primepalindrome()
        {
            for (int i = 1; i <= RANGE; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    int remainder = i % j;
                    if (remainder == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    int reverse = 0;
                    int original = i;
                    while (original != 0)
                    {
                        int rem = original % 10;
                        reverse = (reverse * 10) + rem;
                        original /= 10;
                    }
                    if (reverse == i)
                        Console.Write(i + " ");
                }
            }
        }
    }
}
