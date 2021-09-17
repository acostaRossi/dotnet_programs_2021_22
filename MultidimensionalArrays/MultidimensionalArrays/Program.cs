using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // One-Dimensional Arrays
            //

            Console.WriteLine("\n\nOne-Dimensional Arrays\n");

            // Modalità 1

            Console.WriteLine("\nsArr_1");

            string[] sArr_1 = new string[3];

            sArr_1[0] = "Primo A";
            sArr_1[1] = "Secondo A";
            sArr_1[2] = "Terzo A";

            for (int i = 0; i < sArr_1.GetLength(0); i++) {
                Console.WriteLine("{0, 20}", sArr_1[i]);
            }

            // Modalità 2

            Console.WriteLine("\nsArr_2");

            string[] sArr_2 = new string[] { "Primo B", "Secondo B", "Terzo B" };

            foreach (string sEl in sArr_2) {
                Console.WriteLine("{0, 20}", sEl);
            }

            // Modalità 3

            Console.WriteLine("\nsArr_3");

            string[] sArr_3 = { "Primo C", "Secondo C", "Terzo C" };

            foreach (string sEl in sArr_3) {
                Console.WriteLine("{0, 20}", sEl);
            }

            //
            // Two-Dimensional Arrays
            //

            Console.WriteLine("\n\nTwo-Dimensional Arrays\n");

            // Modalità 1

            Console.WriteLine("\nsArrTwoDim_1");

            string[,] sArrTwoDim_1 = new string[3,2];
            sArrTwoDim_1[0, 0] = "00";
            sArrTwoDim_1[0, 1] = "01";
            sArrTwoDim_1[1, 0] = "10";
            sArrTwoDim_1[1, 1] = "11";
            sArrTwoDim_1[2, 0] = "20";
            sArrTwoDim_1[2, 1] = "21";

            for (int i = 0; i < sArrTwoDim_1.GetLength(0); i++)
            {
                for (int y = 0; y < sArrTwoDim_1.GetLength(1); y++)
                {
                    Console.WriteLine("{0, 20}", sArrTwoDim_1[i, y]);
                }   
            }

            // Modalità 2

            Console.WriteLine("\nsArrTwoDim_2");

            string[,] sArrTwoDim_2 = new string[3, 2] { { "00", "01" } , {  "10", "11" } , {  "20", "21"} };

            foreach (string val in sArrTwoDim_2) {
                Console.WriteLine("{0, 20}", val);
            }

            // Modalità 3

            Console.WriteLine("\nsArrTwoDim_3");

            string[,] sArrTwoDim_3 = { { "00", "01" }, { "10", "11" }, { "20", "21" } };

            foreach (string val in sArrTwoDim_3)
            {
                Console.WriteLine("{0, 20}", val);
            }

            //
            // Jagged Arrays
            //

            Console.WriteLine("\n\nJagged Arrays\n");

            // Modalità 1

            Console.WriteLine("\nsArrJagged_1");

            string[][] sArrJagged_1 = new string[3][];
            sArrJagged_1[0] = new string[] { "00", "01", "02" };
            sArrJagged_1[1] = new string[] { "10", "11", "12" };
            sArrJagged_1[2] = new string[] { "20", "21", "22" };

            for (int i = 0; i < sArrJagged_1.GetLength(0); i++)
            {
                for (int y = 0; y < sArrJagged_1[i].GetLength(0); y++)
                {
                    Console.WriteLine("{0, 20}", sArrJagged_1[i][y]);
                }
            }

            // Modalità 2

            Console.WriteLine("\nsArrJagged_2");

            foreach (string[] arr in sArrJagged_1) {
                foreach (string val in arr) {
                    Console.WriteLine("{0, 20}", val);
                }
            }
        }
    }
}
