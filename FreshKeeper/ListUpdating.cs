using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FreshKeeper
{
    public partial class ListUpdating : Form
    {
        private Dictionary<string, string> foodDictionary;
        public ListUpdating()
        {
            InitializeComponent();
            foodDictionary = new Dictionary<string, string>();
            UpdateListBox();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string foodName = addTextBox.Text.Trim();
            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("Please enter a food name to add.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!foodDictionary.ContainsKey(foodName))
            {
                foodDictionary.Add(foodName, foodName);
                UpdateListBox();
                addTextBox.Clear();
            }
            else
            {
                MessageBox.Show("This food item already exists in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string foodName = deleteTextBox.Text.Trim();
            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("Please enter a food name to delete.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (foodDictionary.Remove(foodName))
            {
                UpdateListBox();
                deleteTextBox.Clear();
            }
            else
            {
                MessageBox.Show("This food item does not exist in the list.", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dashboardForm = new DashBoard(SessionManager.UserName);
            dashboardForm.Show();
            this.Close();
        }
        private void UpdateListBox()
        {
            listUpdatingBox.Items.Clear();
            foreach (var food in foodDictionary.Values)
            {
                listUpdatingBox.Items.Add(food);
            }
        }
    }
}
