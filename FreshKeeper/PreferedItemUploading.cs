using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class PreferedItemUploading : Form
    {
        public event Action PreferedItemAdded;

        public PreferedItemUploading()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (InputValidator.ValidateItemInput(itemNameTextBox.Text.Trim(), quantityTextBox.Text.Trim(), frequencyComboBox))
            {
                string itemName = itemNameTextBox.Text.Trim();
                int preferedQuantity = int.Parse(quantityTextBox.Text.Trim());
                string preferedFrequency = frequencyComboBox.SelectedItem.ToString();

                string query = "INSERT INTO preferences (user_id, item_name, prefer_quantity, frequency, created_at, updated_at) " +
                           "VALUES (@userId, @itemName, @preferredQuantity, @preferredFrequency, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)";

                try
                {
                    DatabaseManager.Instance.ExecuteNonQuery(query, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@preferredQuantity", preferedQuantity);
                        cmd.Parameters.AddWithValue("@preferredFrequency", preferedFrequency);
                    });

                    MessageBox.Show("New preferred item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInputFields();
                    PreferedItemAdded?.Invoke();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the preferred item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearInputFields()
        {
            itemNameTextBox.Clear();
            quantityTextBox.Clear();
            frequencyComboBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreferedItemUploading_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool preferenceListFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is PreferenceList PreferenceListForm)
                {
                    
                    PreferenceListForm.Show();
                    PreferenceListForm.BringToFront(); 
                    preferenceListFormFound = true;
                    break;
                }
            }

            if (!preferenceListFormFound)
            {
                PreferenceList preferenceListForm = new PreferenceList();
                preferenceListForm.Show();
            }
        }

    }
}
