using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            University u1 = new University("UNIPD", "Università di Padova", "Padova");
            University u2 = new University("UNIVR", "Università di Verona", "Verona");
            University u3 = new University("UNIVE", "Università CaFoscari di Venezia", "Venezia");

            University[] arrUni = new University[] {
                u1, u2, u3
            };

            BindingSource bSource = new BindingSource();

            bSource.DataSource = arrUni;

            comboBox1.DataSource = bSource;

            comboBox1.DisplayMember = "UnivName";

            textBox1.DataBindings.Add("Text", bSource, "univName");

            textBox2.DataBindings.Add("Text", bSource, "univAddress");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
