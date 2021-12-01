using System;

namespace SimpleECommerce
{
    class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public string SKU { get; set; }
        public string Label {
            get {
                return $"{Name} - {Brand} - {Price} - {SKU} - {Category.Name}";
            }
        }
        public Category Category{ get; set; }
        public Product(string name, string brand, double price, string sKU, Category category)
        {
            Console.WriteLine("Costruttore con parametri");
            Name = name;
            Brand = brand;
            Price = price;
            SKU = sKU;
            Category = category;
        }
        public Product()
        {
            Console.WriteLine("Costruttore senza parametri");
        }
    }
}
