using System;

namespace Arrays_1D_e_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t************************************");
            Console.WriteLine("\t\t******* Array a 1 dimensione *******");
            Console.WriteLine("\t\t************************************");

            int[] arr1D = { 1, 2, 3, 4 };

            Print1DArray(arr1D, "Array 1D iniziale");

            /*
             * Stampa in console un array a 1 dimensione
             */
            void Print1DArray(int[] arr1DToPrint, string title = "")
            {

                Console.WriteLine("\n");
                Console.CursorLeft = 10;
                Console.WriteLine($"{title}\n");

                foreach (int item in arr1DToPrint)
                {
                    Console.Write("{0, 10}", item);
                }

                Console.WriteLine("\n");
            }

            // array vuoto a 1 dimensione con una cella in piu'
            int[] arr1DNew = new int[arr1D.Length + 1];

            Print1DArray(arr1DNew, "Array 1D vuoto ma piu' grande");

            /*
             * Copia gli elementi di un array a 1 dimensione dentro un altro array
             */
            void Copy1DArray(int[] arr1DOrigin, int[] arr1DDestination)
            {

                for (int i = 0; i < arr1DOrigin.Length; i++)
                {
                    arr1DDestination[i] = arr1DOrigin[i];
                }
            }

            Copy1DArray(arr1D, arr1DNew);

            Print1DArray(arr1DNew, "Array 1D nuovo con gli elementi copiati");

            /*
             * Calcola la somma degli elementi di un array a 1 dimensione.
             * Memorizza il risultato nell'ultima cella dell'array.
             */
            void Calc1DSum(int[] arr1DToSum)
            {

                for (int i = 0; i < arr1DToSum.Length - 1; i++)
                    arr1DToSum[arr1DToSum.Length - 1] += arr1DToSum[i];
            }

            Calc1DSum(arr1DNew);

            Print1DArray(arr1DNew, "Array 1D nuovo con la somme");

            Console.WriteLine("\t\t************************************");
            Console.WriteLine("\t\t******* Array a 2 dimensioni *******");
            Console.WriteLine("\t\t************************************");

            int[,] arr2D = {
                { 1, 2, 3, 4 },
                { 1, 2, 3, 4 },
                { 1, 2, 3, 4 }
            };

            Print2DArray(arr2D, "Array 2D iniziale");

            /*
             * Stampa in console un array a 2 dimensioni
             */
            void Print2DArray(int[,] arr2DToPrint, string title = "")
            {
                Console.WriteLine("\n");
                Console.CursorLeft = 10;
                Console.WriteLine($"{title}\n");

                for (int i = 0; i < arr2DToPrint.GetLength(0); i++)
                {
                    for (int y = 0; y < arr2DToPrint.GetLength(1); y++)
                    {
                        Console.Write("{0, 10}", arr2DToPrint[i, y]);
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }

            // array vuoto a 2 dimensioni con una cella in piu' per riga e colonna
            int[,] arr2DNew = new int[arr2D.GetLength(0) + 1, arr2D.GetLength(1) + 1];

            Print2DArray(arr2DNew, "Array 2D vuoto ma piu' grande");

            Copy2DArray(arr2D, arr2DNew);

            Print2DArray(arr2DNew, "Array 2D nuovo con gli elementi copiati");

            /*
             * Copia gli elementi di un array a 2 dimensioni dentro un altro array
             */
            void Copy2DArray(int[,] arr2DOrigin, int[,] arr2DDestination)
            {
                for (int i = 0; i < arr2DOrigin.GetLength(0); i++)
                {
                    for (int y = 0; y < arr2DOrigin.GetLength(1); y++)
                    {
                        arr2DDestination[i, y] = arr2DOrigin[i, y];
                    }
                }
            }

            Calc2DSum(arr2DNew);

            Print2DArray(arr2DNew, "Array 2D nuovo con la somme");

            /*
             * Calcola la somma per riga e colonna degli elementi di un array a 2 dimensioni.
             * Memorizza il risultato nell'ultima cella dell'array.
             */
            void Calc2DSum(int[,] arr2DToSum)
            {

                for (int i = 0; i < arr2DToSum.GetLength(0) - 1; i++)
                {
                    for (int y = 0; y < arr2DToSum.GetLength(1) - 1; y++)
                    {
                        arr2DToSum[i, arr2DToSum.GetLength(1) - 1] += arr2DToSum[i, y];

                        arr2DToSum[arr2DToSum.GetLength(0) - 1, y] += arr2DToSum[i, y];
                    }
                }
            }
        }
    }
}
