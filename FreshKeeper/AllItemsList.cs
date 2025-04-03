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
    public partial class AllItemsList : Form
    {
        private Dictionary<int, string> itemsDictionary; // Stores the mapping of itemId and item name
        public event Action ItemDeleted;

        public AllItemsList()
        {
            InitializeComponent();
            itemsDictionary = new Dictionary<int, string>();
            LoadAllItems();
        }

        private void LoadAllItems()
        {
            allItemsCheckedListBox.Items.Clear();
            itemsDictionary.Clear();

            string query = "SELECT id, name FROM items WHERE user_id = @userId";

            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            foreach (var row in results)
            {
                int itemId = Convert.ToInt32(row["id"]);
                string itemName = row["name"].ToString();
                allItemsCheckedListBox.Items.Add(itemName);
                itemsDictionary[itemId] = itemName;
            }
        }

        private void ReloadAllItems()
        {
            // reload data
            LoadAllItems();
        }

        private void AddOrUpdateToConsumption(string selectedItem)
        {
            if (allItemsCheckedListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to add or update in consumption.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT quantity, unit_price, health_star_rating FROM items WHERE name = @itemName AND user_id = @userId";
            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@itemName", selectedItem);
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            if (results.Count > 0)
            {
                var row = results[0];
                int quantity = Convert.ToInt32(row["quantity"]);
                float unitPrice = Convert.ToSingle(row["unit_price"]);
                string healthStarRating = row["health_star_rating"].ToString();
                float amountSpent = quantity * unitPrice;

                string consumptionQuery = "SELECT con_quantity, amount_spent FROM consumption WHERE item_name = @itemName AND user_id = @userId";
                var consumptionResults = DatabaseManager.Instance.ExecuteReader(consumptionQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@itemName", selectedItem);
                    cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                });

                if (consumptionResults.Count > 0)
                {
                    var consumptionRow = consumptionResults[0];
                    int existingQuantity = Convert.ToInt32(consumptionRow["con_quantity"]);
                    float existingAmountSpent = Convert.ToSingle(consumptionRow["amount_spent"]);

                    string updateQuery = "UPDATE consumption SET con_quantity = @newQuantity, amount_spent = @newAmountSpent, updated_at = CURRENT_TIMESTAMP " +
                                         "WHERE item_name = @itemName AND user_id = @userId";
                    DatabaseManager.Instance.ExecuteNonQuery(updateQuery, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@newQuantity", existingQuantity + quantity);
                        cmd.Parameters.AddWithValue("@newAmountSpent", existingAmountSpent + amountSpent);
                        cmd.Parameters.AddWithValue("@itemName", selectedItem);
                        cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                    });

                    MessageBox.Show("Item updated successfully in consumption!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string insertQuery = "INSERT INTO consumption (user_id, item_name, con_quantity, amount_spent, health_star_rating, week_start_date, created_at, updated_at) " +
                                         "VALUES (@userId, @itemName, @quantity, @amountSpent, @healthStarRating, @weekStartDate, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)";
                    DatabaseManager.Instance.ExecuteNonQuery(insertQuery, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                        cmd.Parameters.AddWithValue("@itemName", selectedItem);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@amountSpent", amountSpent);
                        cmd.Parameters.AddWithValue("@healthStarRating", healthStarRating);
                        cmd.Parameters.AddWithValue("@weekStartDate", DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek));
                    });

                    MessageBox.Show("Item added successfully to consumption!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Item details could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (allItemsCheckedListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = allItemsCheckedListBox.SelectedItem.ToString();
            int itemId = itemsDictionary.FirstOrDefault(x => x.Value == selectedItem).Key;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                AddOrUpdateToConsumption(selectedItem);
                string deleteQuery = "DELETE FROM items WHERE id = @itemId AND user_id = @userId";
                DatabaseManager.Instance.ExecuteNonQuery(deleteQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                });

                MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllItems();
                ItemDeleted?.Invoke();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (allItemsCheckedListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = allItemsCheckedListBox.SelectedItem.ToString();
            int itemId = itemsDictionary.FirstOrDefault(x => x.Value == selectedItem).Key;

            ItemDetails itemDetailsForm = new ItemDetails(itemId);
            itemDetailsForm.ItemUpdated += ReloadAllItems;
            itemDetailsForm.ShowDialog();
        }

        private void AllItemsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool dashBoardFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is DashBoard DashBoardForm)
                {
                   
                    DashBoardForm.Show();
                    DashBoardForm.BringToFront(); 
                    dashBoardFormFound = true;
                    break;
                }
            }

            if (!dashBoardFormFound)
            {
                DashBoard dashboardForm = new DashBoard(SessionManager.UserName);
                dashboardForm.Show();
            }
        }
    }
}
