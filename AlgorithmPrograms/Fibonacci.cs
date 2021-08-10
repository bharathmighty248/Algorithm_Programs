using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Fibonacci
    {
        int ielement1 = 0, ielement2 = 1;
        int inextElement;
        int relement1 = 0, relement2 = 1, rcounter = 1;
        int rnextElement;
        public void FibonacciByIteration(int elements)
        {
            Console.Write(ielement1 + " " + ielement2 + " ");  //Printing 0 and 1 Initially
            for (int i = 2; i < elements; i++)    //Loop Starts From 2 Because 0 and 1 are Already Printed 
            {
                inextElement = ielement1 + ielement2;
                Console.Write(inextElement + " ");
                ielement1 = ielement2;
                ielement2 = inextElement;
            }
            Console.WriteLine();
        }


        public void FibonacciByRecursion(int elements)
        {
            Console.Write(relement1 + " ");
            if (rcounter < elements)
            {
                rnextElement = relement1 + relement2;
                relement1 = relement2;
                relement2 = rnextElement;
                rcounter++;
                FibonacciByRecursion(elements);
            }
             
        }
    }
}
