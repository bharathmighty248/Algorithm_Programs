using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySearchWord
    {
        bool check = false;

        const string FILEPATH = @"C:\Users\USER\source\repos\AlgorithmPrograms\Words.txt";
        public void Search()
        {
            string words = File.ReadAllText(FILEPATH);
            string[] wordsList = words.Split(","); 
            Console.Write("\nGive the Word To Search: ");
            string searchWord = Console.ReadLine();
            foreach (string word in wordsList)
            {
                if (word.Equals(searchWord))
                {
                    Console.WriteLine("\n\'" + searchWord + "\' is Found in Words List");
                    check = true;
                    break;
                }
            }
            if(check==false)
                Console.WriteLine("\n\'" + searchWord + "\' is Not Found in Words List");
        }
    }
}
