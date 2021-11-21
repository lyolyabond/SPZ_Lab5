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

namespace SPZ_Lab5.View
{
    public partial class StudentEditor : Form
    {
        Student current;
        public StudentEditor()
        {
            InitializeComponent();
        }
        public StudentEditor(object obj)
        {
            InitializeComponent();
            current = obj as Student;
            group_comboBox.Items.AddRange(Group.GroupNamesList.ToArray());
            group_comboBox.Items.Remove(Group.GroupNamesList[0]);
            if (current != null)
            {
                lastname_textBox.Text = current.LastName;
                firstname_textBox.Text = current.FirstName;
                group_comboBox.SelectedItem = current.Group.ToString(); 
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if(current != null)
            Storage.Remove(current);
            this.Close();
        }
        private void edit_button_Click(object sender, EventArgs e)
        {
            if (current.LastName != lastname_textBox.Text)
                current.LastName = lastname_textBox.Text;
            if (current.FirstName != firstname_textBox.Text)
                current.FirstName = firstname_textBox.Text;
            if (current.Group.GroupNumber != group_comboBox.SelectedItem.ToString())
                current.Group.GroupNumber = group_comboBox.SelectedItem.ToString();
            this.Close();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                Storage.Add(new Student(lastname_textBox.Text, firstname_textBox.Text, group_comboBox.SelectedItem.ToString()));
            }
            this.Close();
        }
    }
}
