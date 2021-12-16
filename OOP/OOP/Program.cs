using System;

namespace OOP
{
    interface IVeichle { 
        public string Type { get; set; }
        public string GetName();
    }
    class Program
    {
        class Veicolo : IVeichle
        {
            private string name;
            public string Type { get; set; }
            public string GetName()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Veicolo v = new Veicolo();

            
        }
    }
}
