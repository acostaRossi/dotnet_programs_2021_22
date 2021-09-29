using System;

namespace StringCompression
{
    //Implementare un metodo per eseguire la compressione delle stringhe utilizzando il conteggio dei caratteri ripetuti.
    //Ad esempio, la stringa aabcccccaaa diventerebbe a2blc5a3.
    //Se la stringa "compressa" non diventa più piccola della stringa originale,
    //meglio restituire la stringa originale.
    class Program
    {
        static void Main(string[] args)
        {
            string wordToCompress = "";

            while (wordToCompress.Contains(" ") || wordToCompress.Trim() == "")
            {
                Console.WriteLine("Please write a word: ");

                wordToCompress = Console.ReadLine();
            }

            Console.WriteLine($"Word compressed is: { zip(wordToCompress) }");

            string zip(string word)
            {
                string wordCompressed = "";

                int counter = 0;

                for (int i = 0; i < word.Length; i++)
                {

                    counter++;

                    if (i == word.Length - 1 || word[i] != word[i + 1])
                    {

                        wordCompressed = wordCompressed + word[i] + counter;

                        counter = 0;
                    }
                }

                if (wordCompressed.Length < word.Length)
                {
                    return wordCompressed;
                }
                else
                {
                    return word;
                }
            }

            Console.WriteLine($"Word uncompressed is: { unzip(zip(wordToCompress)) }");

            string unzip(string word)
            {
                string wordUncompressed = "";

                bool isCompressed = false;

                if (wordUncompressed.Length > 1)
                {
                    int n;

                    if (Int32.TryParse(wordUncompressed[1].ToString(), out n))
                    {
                        isCompressed = true;
                    }
                }

                if (isCompressed)
                {
                    for (int i = 0; i < word.Length; i = i + 2)
                    {
                        int counter = Int32.Parse(word[i + 1].ToString());

                        for (int y = 0; y < counter; y++)
                        {
                            wordUncompressed += word[i];
                        }
                    }
                } else {

                    return wordToCompress;
                }

                return wordUncompressed;
            }
        }
    }
}
