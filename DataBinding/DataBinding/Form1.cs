using System;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // string propertyName, object dataSource, string dataMember
            label1.DataBindings.Add("Text", textBox1, "Text");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
