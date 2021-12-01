using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleECommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPInsert_Click(object sender, EventArgs e)
        {

            Product p = new Product()
            {
                Name = textBoxPName.Text,
                Brand = textBoxPBrand.Text,
                Price = Double.Parse(textBoxPPrice.Text),
                SKU = textBoxPSKU.Text
            };

            Product p3 = new Product();
            p3.Name = textBoxPName.Text;
            p3.Brand = textBoxPBrand.Text;
            p3.Price = Double.Parse(textBoxPPrice.Text);
            p3.SKU = textBoxPSKU.Text;
            
            Product p2 = new Product(textBoxPName.Text, textBoxPBrand.Text, Double.Parse(textBoxPPrice.Text), textBoxPSKU.Text)
            {
                Name = "AAA"
            };

        }
    }
}
