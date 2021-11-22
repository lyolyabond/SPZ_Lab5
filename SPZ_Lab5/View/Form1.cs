using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ_Lab5.Model;
using SPZ_Lab5.View;
using System.IO;


namespace SPZ_Lab5
{
    public partial class Form1 : Form
    {
        BindingSource binding;
        BindingSource bsCombobox;
         static string StoragePath { get; } = "Storage.json";
         static string GroupListPath { get; } = "GroupList.json";

        public Form1()
        {
            InitializeComponent();
             
            if(File.Exists(StoragePath) && File.Exists(GroupListPath))
            {
                Storage.Students = Serialization.Deserialize(StoragePath, Storage.Students);
                Group.GroupNamesList = Serialization.Deserialize(GroupListPath, Group.GroupNamesList);
                File.Delete(StoragePath);
            }
            else Storage.Generate();
            binding = new BindingSource();
            
            binding.DataSource = Storage.Students;
            dataGridView.DataSource = binding;

            bsCombobox = new BindingSource();
            bsCombobox.DataSource = Group.GroupNamesList;
            output_comboBox.DataSource = bsCombobox;
            
            dataGridView.ColumnHeaderMouseDoubleClick += OnMouseDoubleClick;
            output_comboBox.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void OnMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            string selectedState = output_comboBox.SelectedItem.ToString();
            switch(e.ColumnIndex)
            {
                case 0:
                    if (output_comboBox.SelectedItem != output_comboBox.Items[0])
                    {
                        binding.DataSource = Storage.SortByLastName(Storage.OutputList(selectedState));
                    }
                    else
                    {
                        Storage.Students = Storage.SortByLastName(Storage.Students);
                        binding.DataSource = Storage.Students;
                    }
                    
                    break;
                case 2:
                    if (output_comboBox.SelectedItem == output_comboBox.Items[0])
                        binding.DataSource = Storage.SortByGroupNumber(Storage.Students);
                    break;
            }
        }
        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = output_comboBox.SelectedItem.ToString();
            if(output_comboBox.SelectedItem == output_comboBox.Items[0])
            {
                binding.DataSource = Storage.Students;
            }
            else binding.DataSource = Storage.OutputList(selectedState);
        }

        private void studentEditor_button_Click(object sender, EventArgs e)
        {
            StudentEditor studentEditor = new StudentEditor(binding.Current);
            studentEditor.ShowDialog();
            binding.ResetBindings(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupEditor groupEditor = new GroupEditor(binding.Current);
            groupEditor.ShowDialog();
            //binding.DataSource = Storage.Students;
            binding.ResetBindings(true);
            bsCombobox.ResetBindings(true);
           // bsCombobox.DataSource = Group.GroupNamesList;
        }
    }
}
