using System;

namespace WhereIsWalford
{
    class Program
    {
        /*
         * Print in console a 2D Array
         */
        static void print2DArray(char[,] _2DArray, bool printIndexes = false, int[,] matches = null)
        {
            Console.WriteLine("\n");

            for (int i = 0; i < _2DArray.GetLength(0); i++) {

                if (printIndexes) {
                    if (i == 0) {
                        Console.Write($" \t");
                        for (int y = 0; y < _2DArray.GetLength(1); y++)
                        {
                            Console.Write($" {y}\t");
                        }
                        Console.WriteLine("\n");
                    }
                }

                for (int y = 0; y < _2DArray.GetLength(1); y++) {
                    if (printIndexes)
                    {   
                        if (y == 0)
                        {
                            Console.Write($" {i}\t");
                        }
                    }

                    if (matches[i, y] > 0) {
                        Console.ForegroundColor = (ConsoleColor)matches[i, y];
                    }
                    Console.Write($" {_2DArray[i, y]}\t");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("\n");
            }
        }
        static int GetAColor()
        {
            int[] colors = { 2, 3, 4, 5, 6, 10, 11, 12, 13, 14 };

            return colors[new Random().Next(0, 9)];
        }
        static void Main(string[] args)
        {
            char[,] arr = {
                { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'g' },
                { 'h', 'e', 'b', 'k', 'w', 'a', 'l', 'd', 'o', 'r', 'f' },
                { 'f', 't', 'y', 'a', 'w', 'a', 'l', 'd', 'o', 'r', 'm' },
                { 'f', 't', 's', 'i', 'm', 'r', 'l', 'q', 's', 'r', 'c' },
                { 'b', 'y', 'o', 'a', 'r', 'b', 'e', 'd', 'e', 'y', 'v' },
                { 'k', 'l', 'c', 'b', 'q', 'w', 'i', 'k', 'o', 'm', 'k' },
                { 's', 't', 'r', 'e', 'b', 'g', 'a', 'd', 'h', 'r', 'b' },
                { 'y', 'u', 'i', 'q', 'l', 'x', 'c', 'n', 'b', 'j', 'f' },
            };

            int[,] occ = new int[arr.GetLength(0), arr.GetLength(1)];

            print2DArray(arr, true, occ);

            string[] words = { "Waldorf" , "Bambi", "Betty", "Dagbert"};

            foreach (string word in words) {
                for (int y = 0; y < arr.GetLength(0); y++) {
                    for (int z = 0; z < arr.GetLength(1); z++) {
                        string wordLowercase = word.ToLower();
                        if (arr[y, z] == wordLowercase[0]) {
                            Find(wordLowercase, y, z, "horizontal right");
                            Find(wordLowercase, y, z, "horizontal left");
                            Find(wordLowercase, y, z, "vertical dowm");
                            Find(wordLowercase, y, z, "vertical up");
                            Find(wordLowercase, y, z, "diagonal left down");
                            Find(wordLowercase, y, z, "diagonal left up");
                            Find(wordLowercase, y, z, "diagonal right down");
                            Find(wordLowercase, y, z, "diagonal right up");
                        }
                    }
                }
            }

            print2DArray(arr, true, occ);

            bool Find(string word, int xCoor, int yCoor, string dir) {

                int xCoorStart = xCoor;

                int yCoorStart = yCoor;

                // search in horizontal direction

                if (dir == "horizontal right")
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        yCoor++;
                        if (yCoor < arr.GetLength(1) && arr[xCoor, yCoor] == word[i])
                        {
                            if (i == word.Length - 1)
                            {
                                int color = GetAColor();
                                Console.WriteLine($"\n\t\tFound \"{word}\" [{xCoorStart},{yCoorStart}] {dir}");
                                for (int z = 0; z < word.Length; z++)
                                {
                                    occ[xCoor, yCoor--] = color;
                                }
                                return true;
                            }
                            continue;
                        }
                        break;
                    }
                }

                if (dir == "horizontal left")
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        yCoor--;
                        if (yCoor >= 0 && arr[xCoor, yCoor] == word[i])
                        {
                            if (i == word.Length - 1)
                            {
                                int color = GetAColor();
                                Console.WriteLine($"\n\t\tFound \"{word}\" [{xCoorStart},{yCoorStart}] {dir}");
                                for (int z = 0; z < word.Length; z++)
                                {
                                    occ[xCoor, yCoor++] = color;
                                }
                                return true;
                            }
                            continue;
                        }
                        break;
                    }
                }

                // search in vertical direction

                if (dir == "vertical dowm")
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        xCoor++;
                        if (xCoor < arr.GetLength(0) && arr[xCoor, yCoor] == word[i])
                        {
                            if (i == word.Length - 1)
                            {
                                int color = GetAColor();
                                Console.WriteLine($"\n\t\tFound \"{word}\" [{xCoorStart},{yCoorStart}] {dir}");
                                for (int z = 0; z < word.Length; z++)
                                {
                                    occ[xCoor--, yCoor] = color;
                                }
                                return true;
                            }
                            continue;
                        }
                        break;
                    }
                }

                if (dir == "vertical up")
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        xCoor--;
                        if (xCoor >= 0 && arr[xCoor, yCoor] == word[i])
                        {
                            if (i == word.Length - 1)
                            {
                                int color = GetAColor();
                                Console.WriteLine($"\n\t\tFound \"{word}\" [{xCoorStart},{yCoorStart}] {dir}");
                                for (int z = 0; z < word.Length; z++)
                                {
                                    occ[xCoor++, yCoor] = color;
                                }
                                return true;
                            }
                            continue;
                        }
                        break;
                    }
                }

                if (dir == "diagonal right down")
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        xCoor++;
                        yCoor++;
                        if (xCoor < arr.GetLength(0) && yCoor < arr.GetLength(1) && arr[xCoor, yCoor] == word[i])
                        {
                            if (i == word.Length - 1)
                            {
                                int color = GetAColor();
                                Console.WriteLine($"\n\t\tFound \"{word}\" [{xCoorStart},{yCoorStart}] {dir}");
                                for (int z = 0; z < word.Length; z++)
                                {
                                    occ[xCoor--, yCoor--] = color;
                                }
                                return true;
                            }
                            continue;
                        }
                        break;
                    }
                }

                if (dir == "diagonal right up")
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        xCoor--;
                        yCoor++;
                        if (xCoor >= 0 && yCoor < arr.GetLength(1) && arr[xCoor, yCoor] == word[i])
                        {
                            if (i == word.Length - 1)
                            {
                                int color = GetAColor();
                                Console.WriteLine($"\n\t\tFound \"{word}\" [{xCoorStart},{yCoorStart}] {dir}");
                                for (int z = 0; z < word.Length; z++)
                                {
                                    occ[xCoor++, yCoor--] = color;
                                }
                                return true;
                            }
                            continue;
                        }
                        break;
                    }
                }

                if (dir == "diagonal left up")
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        xCoor--;
                        yCoor--;
                        if (xCoor >= 0  && yCoor >= 0 && arr[xCoor, yCoor] == word[i])
                        {
                            if (i == word.Length - 1)
                            {
                                int color = GetAColor();
                                Console.WriteLine($"\n\t\tFound \"{word}\" [{xCoorStart},{yCoorStart}] {dir}");
                                for (int z = 0; z < word.Length; z++)
                                {
                                    occ[xCoor++, yCoor++] = color;
                                }
                                return true;
                            }
                            continue;
                        }
                        break;
                    }
                }

                if (dir == "diagonal left down")
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        xCoor++;
                        yCoor--;
                        if (xCoor < arr.GetLength(0) && yCoor >= 0 && arr[xCoor, yCoor] == word[i])
                        {
                            if (i == word.Length - 1)
                            {
                                int color = GetAColor();
                                Console.WriteLine($"\n\t\tFound \"{word}\" [{xCoorStart},{yCoorStart}] {dir}");
                                for (int z = 0; z < word.Length; z++)
                                {
                                    occ[xCoor--, yCoor++] = color;
                                }
                                return true;
                            }
                            continue;
                        }
                        break;
                    }
                }

                return false;
            }
        }
    }
}
