using System;

namespace SimpleECommerce4CII
{
    class Product
    {
        private bool _enabled = false; // FIELD
        public string Name { get; set; }
        public double Price { get; set; }
        public string Display { get {

                return $"{Name}, {Price}, {Category.Name}";
            
            }
        }
        public Category Category { get; set; }
        public bool Enabled
        { // PROPERTY 
            get => _enabled;
            set
            {
                if (Price > 0)
                {
                    _enabled = value;
                }
                throw new ArgumentException("Price must be grater than 0");
            }
        }
        //public void setEnabled(bool value)
        //{
        //    if (Price > 0)
        //    {
        //        _enabled = value;
        //    }
        //    throw new ArgumentException("Price must be grater than 0");

        //}
        //public bool getEnabled()
        //{
        //    return _enabled;
        //}
        public Product(string name, double price = 0)
        {
            Name = name;
            Price = price;
        }
        public Product(string name, double price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
