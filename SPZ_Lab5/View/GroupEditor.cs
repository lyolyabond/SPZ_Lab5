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
    public partial class GroupEditor : Form
    {
        Student current;
        public GroupEditor()
        {
            InitializeComponent();
        }
        public GroupEditor(object obj)
        {
            InitializeComponent();
            current = obj as Student;
            listGroup_comboBox.Items.AddRange(Group.GroupNamesList.ToArray());
            listGroup_comboBox.Items.Remove(Group.GroupNamesList[0]);
            if (current != null)
            {
                listGroup_comboBox.SelectedItem = current.Group.ToString();
                newGroup_textBox.Text = current.Group.ToString();
            }
            //Form1.binding.ResetBindings(true);
        }
        private void deleteGroup_button_Click(object sender, EventArgs e)
        {
            string groupName;
            if((groupName = listGroup_comboBox.SelectedItem.ToString()) != null)
            Storage.RemoveGroup(groupName);
            this.Close();
        }

        private void rename_button_Click(object sender, EventArgs e)
        {
            string newGroup = newGroup_textBox.Text;
            string oldGroup = listGroup_comboBox.SelectedItem.ToString();
            Group.Rename(oldGroup, newGroup);
            Storage.RenameGroup(oldGroup, newGroup);
            this.Close();
        }

        private void addGroup_button_Click(object sender, EventArgs e)
        {
            Group.Add(newGroup_textBox.Text);
            this.Close();
        }
    }
}
