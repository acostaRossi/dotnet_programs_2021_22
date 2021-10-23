using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadAndWriteDataFromFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }
        void Init()
        {
            string[] dataFile = File.ReadAllLines(@"..\..\Data.txt");

            string[,] people = new string[dataFile.Length, 3];

            int y = 0;

            foreach (var line in dataFile)
            {
                string[] data = line.Split(';');

                people[y, 0] = data[0];
                people[y, 1] = data[1];
                people[y, 2] = data[2];

                y++;
            }

            for (int i = 0; i < people.GetLength(0); i++)
            {
                listBoxPeople.Items.Add($"{ people[i, 0] },{ people[i, 1] },{ people[i, 2] }");
            }
        }

        private void listBoxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = listBoxPeople.SelectedItem;

            if (itemSelected == null) return;

            listBoxSelected.Items.Add(itemSelected);

            listBoxPeople.Items.Remove(listBoxPeople.SelectedItem);
        }

        private void listBoxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = listBoxSelected.SelectedItem;

            if (itemSelected == null) return;

            listBoxPeople.Items.Add(itemSelected);

            listBoxSelected.Items.Remove(listBoxSelected.SelectedItem);
        }

        private void buttonWriteIntoFile_Click(object sender, EventArgs e)
        {   
            string[] lines = new string[listBoxPeople.Items.Count];

            int i = 0;

            foreach (string item in listBoxSelected.Items)
            {
                lines[i] = item.Replace(", ", ";");

                i++;
            }

            File.WriteAllLines(@"..\..\Result.txt", lines);
        }
    }
}
