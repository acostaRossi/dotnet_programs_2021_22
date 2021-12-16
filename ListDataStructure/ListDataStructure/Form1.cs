using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListDataStructure
{
    public partial class Form1 : Form
    {
        private BindingList<Person> _list;
        private Filters _filters;
        private string[] _sortFields = { "Name", "Age" };
        private string[] _sortTypes = { "Ascending", "Descending" };
        public Form1()
        {
            InitializeComponent();

            _list = new BindingList<Person>(Seeder.GetPeople());

            _filters = new Filters() { NameFilter = "", AgeFilter = "" };

            _filters.ValueChanged += ApplyFilters;

            BindData(_list);
        }
        private void InsertData(string name, int age)
        {
            //_list.ResetBindings();
            _list.Add(new Person() { Name = name, Age = age });
        }
        private void ClearData()
        {
            textBoxName.Clear();
            textBoxAge.Clear();
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                InsertData(textBoxName.Text, Int32.Parse(textBoxAge.Text));
                ClearData();
            }
            catch (Exception)
            {
                MessageBox.Show("Dati non validi");
            }
        }
        private void BindData(BindingList<Person> list, bool forceAll = true)
        {
            BindingSource bSource = new BindingSource { DataSource = list };

            listBoxData.DataSource = bSource;

            listBoxData.DisplayMember = "Print";

            if (!forceAll) return;

            textBoxEditName.DataBindings.Add("Text", bSource, "Name", false, DataSourceUpdateMode.OnPropertyChanged);

            textBoxEditAge.DataBindings.Add("Text", bSource, "Age", false, DataSourceUpdateMode.OnPropertyChanged);

            textBoxFilterName.DataBindings.Add("Text", _filters, "NameFilter", false, DataSourceUpdateMode.OnPropertyChanged);

            textBoxFilterAge.DataBindings.Add("Text", _filters, "AgeFilter", false, DataSourceUpdateMode.OnPropertyChanged);

            labelFilters.DataBindings.Add("Text", _filters, "AllFilters", false, DataSourceUpdateMode.OnPropertyChanged);

            comboBoxSortBy.DataSource = _sortFields;

            comboBoxSortType.DataSource = _sortTypes;
        }
        void ApplyFilters(object sender, EventArgs e)
        {
            List<Person> filteredList = new List<Person>(_list);

            if (_filters.NameFilter != "")
            {
                filteredList = filteredList.Where(person => person.Name == _filters.NameFilter).ToList();
            }

            if (_filters.AgeFilter != "")
            {
                filteredList = filteredList.Where(person => person.Age == Int32.Parse(_filters.AgeFilter)).ToList();
            }

            BindData(new BindingList<Person>(filteredList), false);
        }
        private void SortData()
        {
            if (comboBoxSortBy.SelectedIndex == -1) return;
            string fieldToSort = _sortFields[comboBoxSortBy.SelectedIndex];

            if (comboBoxSortType.SelectedIndex == -1) return;
            string sortingType = _sortTypes[comboBoxSortType.SelectedIndex];

            List<Person> filteredList = new List<Person>(_list);

            if (sortingType == "Ascending")
            {
                filteredList = filteredList.OrderBy(person => person.GetType().GetProperty(fieldToSort).GetValue(person, null)).ToList();
            }
            else
            {
                filteredList = filteredList.OrderByDescending(person => person.GetType().GetProperty(fieldToSort).GetValue(person, null)).ToList();
            }

            BindData(new BindingList<Person>(filteredList), false);
        }
        private void comboBoxSortBy_SelectedValueChanged(object sender, EventArgs e)
        {
            SortData();
        }
        private void comboBoxSortType_SelectedValueChanged(object sender, EventArgs e)
        {
            SortData();
        }
    }
}
