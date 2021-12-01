using System;

namespace SimpleECommerce
{
    class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public string SKU { get; set; }
        public Category category{ get; set; }
        public Product(string name, string brand, double price, string sKU)
        {
            Console.WriteLine("Costruttore con parametri");
            Name = name;
            Brand = brand;
            Price = price;
            SKU = sKU;
        }
        public Product()
        {
            Console.WriteLine("Costruttore senza parametri");
        }

    }
}
