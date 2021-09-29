using System;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // input number
            int n = 0;

            // min number allowed
            int minN = 1;

            // max number allowed
            int maxN = 1000000;

            // get input number (beetween 0 and 1000000)
            while (n<= minN || n>maxN)
            {
                // print question
                Console.Write($"Please, digit a number (beetween {minN} and {maxN}): ");

                // using TryParse and out parameters
                Int32.TryParse(Console.ReadLine(), out n);
            }

            // operation counter
            int counter = 0;

            // print 30 spaces right
            Console.CursorLeft = 30;

            while (n != 1) {

                // increase operations counter
                counter++;

                // check if even or odd
                bool even = (n % 2 == 0) ? true : false;

                // set text color
                Console.ForegroundColor = even ? ConsoleColor.Green : ConsoleColor.Magenta;

                // print number
                Console.Write($"{n} ");

                // calc new number
                n = even ? n / 2 : (n * 3) + 1;
            }

            // set Magenta color and print 1
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(n);

            // restore default text color
            Console.ForegroundColor = ConsoleColor.White;

            // print steps number required in order to complete the algorithm
            Console.WriteLine($"\n{counter} step required.");
        }
    }
}
