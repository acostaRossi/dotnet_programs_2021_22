using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleECommerce4CII
{

    class User {
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }
    }
    class Category {
        public string Name { get; set; }
        public Category(string name)
        {
            Name = name;
        }
    }
    class Product {
        private bool _enabled = false; // FIELD
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Enabled { // PROPERTY 
            get => _enabled;
            set {
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
        public Product(string name)
        {
            Name = name;
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
    class Seller {
        public string Name { get; set; }
        public string IBAN { get; set; }
        public List<User> admins { get; set; }
        public Seller(string name, string iBAN, List<User> admins)
        {
            Name = name;
            IBAN = iBAN;
            if (admins.Count > 5) {
                throw new ArgumentException("List must be less than 5");
            }
            this.admins = admins;
        }
        public Seller(string name, string iBAN, User admin)
        {
            Name = name;
            IBAN = iBAN;

            admins = new List<User>(5);

            admins.Add(admin);
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            User u = new User("Alberto");

            Seller s = new Seller("Costa tech", "asasasasa", u);
            
            Product p = new Product("IPhone") {
                Price = 100,
                Name = "s10"
            };

            Category c = new Category("Phones");




            




        }
    }
}
