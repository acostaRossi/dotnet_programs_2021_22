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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Department dep1 = new Department("Informatica");
            dep1.Students.Add(new Student("Gattuso Gennaro", "Milano"));
            dep1.Students.Add(new Student("Balotelli Mario", "Vicenza"));
            dep1.Students.Add(new Student("Williams Serena", "Verona"));

            Department dep2 = new Department("Meccanica");
            dep2.Students.Add(new Student("Chiesa Enrico", "Roma"));
            dep2.Students.Add(new Student("Pellegrini Federica", "Venezia"));
            dep2.Students.Add(new Student("Maldini Paolo", "Bologna"));

            Department[] departments = new Department[] { dep1, dep2 };

            BindingSource comboBoxSource = new BindingSource();

            comboBoxSource.DataSource = departments;

            comboBox1.DataSource = comboBoxSource;

            comboBox1.DisplayMember = "DepartmentName";

            BindingSource listBoxSource = new BindingSource();

            listBoxSource.DataSource = comboBox1.DataSource;

            listBoxSource.DataMember = "Students";

            listBox1.DataSource = listBoxSource;

            listBox1.DisplayMember = "StudentName";
        }
    }
}
