using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumbers
    {
        const int RANGE = 1000;
        public void PrimeNumber()
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
                if(count==2)
                    Console.Write(i + " ");
            }
        }
    }
}
