using MySql.Data.MySqlClient;
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
    public partial class PreferenceList : Form
    {
        public PreferenceList()
        {
            InitializeComponent();
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            preferenceCheckedListBox.Items.Clear();

            string query = "SELECT item_name FROM preferences WHERE user_id = @userId";

            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            foreach (var row in results)
            {
                string itemName = row["item_name"].ToString();
                preferenceCheckedListBox.Items.Add(itemName);
            }
        }

        private void ReloadPreferences()
        {
            // Method to reload data
            LoadPreferences();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (preferenceCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in preferenceCheckedListBox.CheckedItems)
            {
                string itemName = item.ToString();
                string query = "DELETE FROM preferences WHERE user_id = @userId AND item_name = @itemName";

                DatabaseManager.Instance.ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                });
            }

            MessageBox.Show("Selected items deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadPreferences(); // Refresh the list
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            PreferedItemUploading preferenceItemUploadingForm = new PreferedItemUploading();
            preferenceItemUploadingForm.PreferedItemAdded += ReloadPreferences;
            preferenceItemUploadingForm.ShowDialog();
        }

        private void PreferenceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool personalPageFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is PersonalPage PersonalPageForm)
                {
                    // If an existing Login form is found, display it
                    PersonalPageForm.Show();
                    PersonalPageForm.BringToFront(); 
                    personalPageFormFound = true;
                    break;
                }
            }

            if (!personalPageFormFound)
            {
                PersonalPage personalPageForm = new PersonalPage();
                personalPageForm.Show();
            }
        }
    }
}
