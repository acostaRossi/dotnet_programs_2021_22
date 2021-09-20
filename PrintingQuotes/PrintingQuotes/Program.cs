using System;

namespace PrintingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n**************** START ****************\n\n");

            //

            const string question1 = "What is the quote ?";

            const string question2 = "Who said it ?";

            string[,] inputs = new string[3,2];

            string phrase, author;

            for (int i = 0; i < 3; i++) {

                phrase = "";

                while (phrase.Trim() == "") {

                    Console.WriteLine($"{question1}\t");

                    phrase = Console.ReadLine();
                }

                inputs[i, 0] = phrase;

                author = "";

                while (author.Trim() == "")
                {
                    Console.WriteLine($"{question2}\t");

                    author = Console.ReadLine();
                }

                inputs[i, 1] = author;
            }

            printQuotes(inputs);
        }

        static void printQuotes(string[,] data) {

            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{data[i, 1]} said: \"{data[i, 0]}\"");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
