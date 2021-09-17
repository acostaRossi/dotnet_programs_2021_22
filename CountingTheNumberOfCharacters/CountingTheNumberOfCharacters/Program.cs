using System;

namespace CountingTheNumberOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n**************** START ****************\n\n");

            //

            string word = "";

            while (word.Trim() == "") {

                Console.Write("What is the input string ?\t");

                word = Console.ReadLine();
            }

            word = word.Replace(" ", "");

            Console.WriteLine(word);

            int wordLength = word.Length;

            Console.WriteLine($"{word} has {wordLength} characters");
        }
    }
}
