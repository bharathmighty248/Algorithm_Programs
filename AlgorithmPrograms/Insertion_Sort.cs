using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    class Insertion_Sort
    {
        const string FILEPATH = @"C:\Users\USER\source\repos\AlgorithmPrograms\Words.txt";
        public void InsertionSort()
        {
            string words = File.ReadAllText(FILEPATH);
            string[] wordsList = words.Split(",");
            Console.Write("\nBefore insertion sort wordList is: ");
            foreach (string word in wordsList)
            {
                Console.Write(word + " ");
            }

            for (int i = 1; i < wordsList.Length; i++)
            {
                string temp = wordsList[i];
                int j = i - 1;
                while (j >= 0 && temp.CompareTo(wordsList[j]) == -1)
                {
                    wordsList[j + 1] = wordsList[j];
                    j--;
                }
                wordsList[j + 1] = temp;
            }
            Console.Write("\nAfter insertion sort wordList is: ");
            foreach (string word in wordsList)
            {
                Console.Write(word + " ");
            }
        }
    }
}
