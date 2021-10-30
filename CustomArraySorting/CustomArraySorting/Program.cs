using System;

namespace CustomArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "1", "11", "2", "22", "3", };

            Array.Sort(arr, delegate (string s1, string s2)
            {
                int n1 = Int32.Parse(s1);
                int n2 = Int32.Parse(s2);

                if (n1 > n2) return 1;

                return -1;
            });

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
