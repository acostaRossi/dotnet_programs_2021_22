using System;
using System.Numerics;

namespace Factorial
{
    class Factorial {

        public int calcRecursive(int n)
        {

            if (n <= 1)
            {
                return 1;
            }

            return n * calcRecursive(n - 1);
        }

        public int calcIterative(int n)
        {
            int result = 1;

            if (n <= 1)
            {
                return result;
            }

            for (int i = n; i >= 1; i--)
            {
                result = result * i;
            }

            return result;
        }

        public long calcRecursive(long n) {

            if (n <= 1)
            {
                return 1;
            }

            return n * calcRecursive(n - 1);
        }

        public long calcIterative(long n)
        {
            long result = 1;

            if (n <= 1)
            {
                return result;
            }

            for (long i = n; i >= 1; i--)
            {
                result = result * i;
            }

            return result;
        }
        public ulong calcRecursive(ulong n)
        {

            if (n <= 1)
            {
                return 1;
            }

            return n * calcRecursive(n - 1);
        }
        public ulong calcIterative(ulong n)
        {
            ulong result = 1;

            if (n <= 1)
            {
                return result;
            }

            for (ulong i = n; i >= 1; i--)
            {
                result = result * i;
            }

            return result;
        }
        public BigInteger calcRecursive(BigInteger n)
        {

            if (n <= 1)
            {
                return 1;
            }

            return n * calcRecursive(n - 1);
        }

        public BigInteger calcIterative(BigInteger n)
        {
            BigInteger result = 1;

            if (n <= 1)
            {
                return result;
            }

            for (BigInteger i = n; i >= 1; i--)
            {
                result = result * i;
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string msg1 = "Press Enter for continue, Write 'exit' for quit";

            string msg2 = "Please give me a number!";

            Console.WriteLine(msg1);

            while (Console.ReadLine() != "exit")
            {
                Console.Write($"{ msg2 }\t");
                int input;

                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write($"{ msg2 }\t");
                }

                Factorial fact = new Factorial();

                Console.WriteLine($"{ input }! = { fact.calcIterative((int) input) }   (Iterative algorithm) with int");

                Console.WriteLine($"{ input }! = { fact.calcRecursive((int) input) }   (Recursive algorithm) with int");

                Console.WriteLine($"{ input }! = { fact.calcIterative((long) input) }   (Iterative algorithm) with long");

                Console.WriteLine($"{ input }! = { fact.calcRecursive((long) input) }   (Recursive algorithm) with long");

                Console.WriteLine($"{ input }! = { fact.calcIterative((ulong) input) }   (Iterative algorithm) with ulong");

                Console.WriteLine($"{ input }! = { fact.calcRecursive((ulong) input) }   (Recursive algorithm) with ulong");

                Console.WriteLine($"{ input }! = { fact.calcIterative((BigInteger) input) }   (Iterative algorithm with BigInteger)");

                Console.WriteLine($"{ input }! = { fact.calcRecursive((BigInteger) input) }   (Recursive algorithm) with BigInteger");

                Console.WriteLine($"\n\n{ msg1 }");
            }
        }
    }
}
