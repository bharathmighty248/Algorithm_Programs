using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class OptionSelection
    {
        public void Option()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\nWelcome to Algorithm Programs\n" +
                "1. Fibonacci By Using Iteration And Recursion Methods\n" +
                "2. Binary Search Word From Word List\n" +
                "3. Insertion Sort\n" +
                "4. Bubble Sort\n" +
                "5. Merge Sort\n" +
                "6. Anagram\n" +
                "7. PrimeNumbers 1 t0 1000\n" +
                "8. Prime Palindrome 1 t0 1000\n" +
                "" +
                "9. End");
                Console.Write("Please Select One Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("\nFibonacci Series By using Iteration: ");
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.FibonacciByIteration(15);
                        Console.Write("\nFibonacci Series By using Recursion: ");
                        fibonacci.FibonacciByRecursion(15);
                        break;
                    case 2:
                        BinarySearchWord word = new BinarySearchWord();
                        word.Search();
                        break;
                    case 3:
                        Insertion_Sort insertionSort = new Insertion_Sort();
                        insertionSort.InsertionSort();
                        break;
                    case 4:
                        Bubble_Sort bubbleSort = new Bubble_Sort();
                        bubbleSort.BubbleSort();
                        break;
                    case 5:
                        int[] arr = { 12, 11, 13, 5, 6, 7 };
                        Merge_Sort mergeSort = new Merge_Sort();
                        Console.Write("\nBefore Merge Sort is: ");
                        mergeSort.Display(arr);
                        mergeSort.sort(arr, 0, arr.Length - 1);
                        Console.Write("\nAfter Merge Sort is: ");
                        mergeSort.Display(arr);
                        break;
                    case 6:
                        Anagram anagram = new Anagram();
                        bool anagramCheck=anagram.IsAnagram("heart", "earth");
                        if (anagramCheck == true)
                            Console.WriteLine("\n\'heart\' and \'earth\' Are Anagram");
                        else
                            Console.WriteLine("\n\'heart\' and \'earth\' Are Not Anagram");
                        break;
                    case 7:
                        PrimeNumbers primeNumbers = new PrimeNumbers();
                        Console.Write("\nPrime Numbers Between Range 1 to 1000 Are: ");
                        primeNumbers.PrimeNumber();
                        break;
                    case 8:
                        PrimePalindrome primePalindrome = new PrimePalindrome();
                        Console.Write("\nPrime Palindromes Between Range 1 to 1000 Are: ");
                        primePalindrome.Primepalindrome();
                        break;
                    case 9:
                        Console.WriteLine("\nThankYou..");
                        break;
                }
                if (option == 9)
                    break;
            }
        }
    }
}
