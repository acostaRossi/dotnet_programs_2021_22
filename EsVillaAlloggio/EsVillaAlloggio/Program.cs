using System;

namespace EsVillaAlloggio
{
    class Program
    {
        public static void Main(string[] args)
        {
            Villa villa = new Villa("Top", 4, 200, 1000);

            Console.WriteLine(villa.CostoAcqua(10));
        }
    }
}
