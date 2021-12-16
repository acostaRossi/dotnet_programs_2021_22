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

    public partial class Form1 : Form
    {
        List<Category> categories;
        List<Product> products;
        public Form1()
        {
            InitializeComponent();

            categories = new List<Category>() { 
                new Category("Phones"),
                new Category("Books"),
                new Category("Films"),
            };

            products = new List<Product>();

            BindData();

            User u1 = new User("Alberto");

            Seller s = new Seller("Costa tech", "asasasasa", u1);

            s.AddAdmin(new User("Mattia"));
            s.AddAdmin(new User("Ugo"));
            s.AddAdmin(new User("Gino"));
            s.AddAdmin(new User("Giuseppe"));
            s.AddAdmin(new User("Mario"));



            //Product p = new Product("IPhone") {
            //    Price = 100,
            //    Name = "s10"
            //};

            //Category c = new Category("Phones");

        }

        private void buttonCatCreate_Click(object sender, System.EventArgs e)
        {
            categories.Add(new Category(textBoxCatName.Text));

            BindData();
        }

        private void buttonPCreate_Click(object sender, System.EventArgs e)
        {
            Product p;
            if (comboBoxPCategory.SelectedItem == null)
            {
                p = new Product(textBoxPName.Text, double.Parse(textBoxPPrice.Text));
            } else {
                Category catselected = comboBoxPCategory.SelectedItem as Category;
                p = new Product(textBoxPName.Text, double.Parse(textBoxPPrice.Text), catselected);
            }

            if (p != null)
            {
                products.Add(p);
            }

            BindData();
        }

        private void BindData() {
            comboBoxPCategory.DataSource = null;
            comboBoxPCategory.DataSource = categories;
            comboBoxPCategory.DisplayMember = "Name";

            listBoxProducts.DataSource = null;
            listBoxProducts.DataSource = products;
            listBoxProducts.DisplayMember = "Display";
        }

        private void buttonPrint_Click(object sender, System.EventArgs e)
        {   
            MessageBox.Show(products[products.Count - 1].Name);
        }
    }
}
