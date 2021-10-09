using System;

namespace Eratostene
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
            int maxN = 1000;

            // get input number (beetween 0 and 1000)
            while (n <= minN || n > maxN)
            {
                // print question
                Console.Write($"Please, digit a number (beetween {minN} and {maxN}): ");

                // using TryParse and out parameters
                Int32.TryParse(Console.ReadLine(), out n);
            }

            // new empty array
            int[] arr = new int[n-1];

            // init array elements [2, 3, ..., n]
            for (int i = 0; i < n - 1; i++)
            {
                arr[i] = i + 2;
            }

            Console.WriteLine("\nOriginal numbers are:");

            PrintNumbers(arr);

            DeleteMultiples(arr);

            //Console.WriteLine("\n\nRemoved the number that are not prime:");

            //PrintNumbers(arr);

            Console.WriteLine("\nPrime numbers are:");

            CreateFinalArray(arr);

            // Print array values
            void PrintNumbers(int[] arrTopPrint)
            {
                for (int i = 0; i < arrTopPrint.Length; i++)
                {
                    Console.Write(arrTopPrint[i] + " ");
                }

                Console.WriteLine("");
            }

            // Delete multiples of an input number from the array
            void DeleteMultiples(int[] arrWithNumbers)
            {
                for (int i = 0; i < arrWithNumbers.Length; i++)
                {   
                    for (int y = i+1; y < arrWithNumbers.Length; y++)
                    {
                        if (arrWithNumbers[i] > 0 && arrWithNumbers[y] % arrWithNumbers[i] == 0)
                        {
                            arrWithNumbers[y] = 0;
                        }
                    }
                }
            }

            // create an array with prime numbers
            void CreateFinalArray(int[] arrWithNumbers)
            {
                // count the prime numbers
                int counter = 0;

                for (int i = 0; i < arrWithNumbers.Length; i++)
                {
                    if (arrWithNumbers[i] > 0) counter++;
                }

                // create an array for prime numbers
                int[] finalArray = new int[counter];
                // insert the prime numbers in new array
                int index = 0;

                for (int i = 0; i < arrWithNumbers.Length; i++)
                {
                    if (arrWithNumbers[i] > 0)
                    {
                        finalArray[index++] = arrWithNumbers[i];
                    };
                }

                PrintNumbers(finalArray);
            }
        }
    }
}
