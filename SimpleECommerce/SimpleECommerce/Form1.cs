using System;
using System.Collections.Generic;
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
        List<Category> categories;
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            categories = new List<Category>() { 
                new Category("Tech"),
                new Category("Home"),
                new Category("Books"),
                new Category("Papers"),
            };

            products = new List<Product>();

            BindData();
        }
        private void buttonPInsert_Click(object sender, EventArgs e)
        {
            Category cat = comboBoxPCategory.SelectedItem as Category;

            Product product = new Product(textBoxPName.Text,
                textBoxPBrand.Text,
                Double.Parse(textBoxPPrice.Text),
                textBoxPSKU.Text,
                cat
            );

            products.Add(product);

            BindData();
        }
        private void buttonCategoryCreate_Click(object sender, EventArgs e)
        {
            categories.Add(new Category(textBoxCategoryName.Text));

            BindData();
        }
        private void BindData()
        {
            comboBoxPCategory.DataSource = null;
            comboBoxPCategory.DataSource = categories;

            comboBoxPCategory.DisplayMember = "Name";

            comboBoxPCategory.ValueMember = "Name";

            listBoxScaffal.DataSource = null;
            listBoxScaffal.DataSource = products;
            listBoxScaffal.DisplayMember = "Label";
        }

        private void buttonStampa_Click(object sender, EventArgs e)
        {   
            MessageBox.Show(products[0].Name);
        }
    }
}
