using System;
using System.Drawing;
using static System.Console;
using static System.Math;

namespace StaticKeyword
{
    static class Car {

        public static string name;

        public static Color color;

        public static int fanton2meno;
        public static string Print()
        {
            return $"name={name}     color={color.Name}";
        }
    }
    class Program
    {
        static int age = 10;
        static void Main(string[] args)
        {
            //Car c = new Car();

            WriteLine("Maradini non me l'aspettavo, Dorde adesso basta");

            ForegroundColor = ConsoleColor.Red;

            WriteLine("Maradini non me l'aspettavo, Dorde adesso basta");

        }
        
    }
    
}
