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
    public partial class ItemDetails : Form
    {
        private Dictionary<string, int> categoryDictionary;
        private int itemId;
        public event Action ItemUpdated;

        public ItemDetails(int selectedItemId)
        {
            InitializeComponent();
            itemId = selectedItemId;
            InitializeCategoryDictionary();
            LoadItemDetails();// Populate list
        }

        private void LoadItemDetails()
        {
            string query = "SELECT name, expiration_date, unit_price, quantity, health_star_rating, category_id, preference " +
                       "FROM items WHERE id = @itemId AND user_id = @userId";

            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@itemId", itemId);
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            if (results.Count > 0)
            {
                var row = results[0];
                itemNameTextBox.Text = row["name"].ToString();
                bestBeforeDateTimePicker.Value = Convert.ToDateTime(row["expiration_date"]);
                unitPriceTextBox.Text = Convert.ToSingle(row["unit_price"]).ToString();
                quantityTextBox.Text = Convert.ToInt32(row["quantity"]).ToString();
                healthStarRatingComboBox.SelectedItem = row["health_star_rating"].ToString();

                int categoryId = Convert.ToInt32(row["category_id"]);
                categoryComboBox.SelectedItem = categoryDictionary.FirstOrDefault(x => x.Value == categoryId).Key;

                string preference = row["preference"].ToString();
                yesRadioButton.Checked = preference == "yes";
                noRadioButton.Checked = preference == "no";
            }
            else
            {
                MessageBox.Show("No item details found for the selected item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeCategoryDictionary()
        {
            categoryDictionary = new Dictionary<string, int>();
            string query = "SELECT cate_id, cate_name FROM categories";

            var results = DatabaseManager.Instance.ExecuteReader(query, cmd => { });

            foreach (var row in results)
            {
                int categoryId = Convert.ToInt32(row["cate_id"]);
                string categoryName = row["cate_name"].ToString();
                categoryDictionary[categoryName] = categoryId;
            }
        }

        private void AddToPreferencesIfNotExists(string itemName)
        {
            string checkQuery = "SELECT COUNT(*) FROM preferences WHERE user_id = @user_id AND item_name = @item_name";
            var countResult = DatabaseManager.Instance.ExecuteScalar(checkQuery, cmd =>
            {
                cmd.Parameters.AddWithValue("@user_id", SessionManager.UserId);
                cmd.Parameters.AddWithValue("@item_name", itemName);
            });

            int count = Convert.ToInt32(countResult);
            if (count == 0) 
            {
                string insertQuery = "INSERT INTO preferences (user_id, item_name, created_at, updated_at) " +
                                     "VALUES (@user_id, @item_name, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)";
                DatabaseManager.Instance.ExecuteNonQuery(insertQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@user_id", SessionManager.UserId);
                    cmd.Parameters.AddWithValue("@item_name", itemName);
                });
            }
        }

        private void AddOrUpdateConsumption()
        {
            string itemName = itemNameTextBox.Text.Trim();
            int quantity = int.Parse(quantityTextBox.Text);
            float unitPrice = float.Parse(unitPriceTextBox.Text);
            float amountSpent = quantity * unitPrice;

            string checkQuery = "SELECT con_id, con_quantity, amount_spent FROM consumption WHERE user_id = @userId AND item_name = @itemName";
            var results = DatabaseManager.Instance.ExecuteReader(checkQuery, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                cmd.Parameters.AddWithValue("@itemName", itemName);
            });

            if (results.Count > 0)
            {
                var row = results[0];
                int conId = Convert.ToInt32(row["con_id"]);
                int currentQuantity = Convert.ToInt32(row["con_quantity"]);
                decimal currentAmountSpent = Convert.ToDecimal(row["amount_spent"]);

                int newQuantity = currentQuantity + quantity;
                decimal newAmountSpent = currentAmountSpent + (quantity * (decimal)unitPrice);

                string updateQuery = "UPDATE consumption SET con_quantity = @newQuantity, amount_spent = @newAmountSpent, updated_at = CURRENT_TIMESTAMP WHERE con_id = @conId";
                DatabaseManager.Instance.ExecuteNonQuery(updateQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                    cmd.Parameters.AddWithValue("@newAmountSpent", newAmountSpent);
                    cmd.Parameters.AddWithValue("@conId", conId);
                });
            }
            else
            {
                string insertQuery = "INSERT INTO consumption (user_id, item_name, con_quantity, amount_spent, health_star_rating, week_start_date, created_at, updated_at) " +
                                     "VALUES (@userId, @itemName, @quantity, @amountSpent, @healthStarRating, @weekStartDate, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)";

                DatabaseManager.Instance.ExecuteNonQuery(insertQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@amountSpent", amountSpent);
                    cmd.Parameters.AddWithValue("@healthStarRating", healthStarRatingComboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@weekStartDate", DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek));
                });
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (InputValidator.ValidateItemInput(itemNameTextBox.Text.Trim(), quantityTextBox.Text.Trim(), null, healthStarRatingComboBox, categoryComboBox))
            {
                string itemName = itemNameTextBox.Text.Trim();
                DateTime expirationDate = bestBeforeDateTimePicker.Value;
                float unitPrice = float.Parse(unitPriceTextBox.Text);
                int quantity = int.Parse(quantityTextBox.Text);
                string healthStarRating = healthStarRatingComboBox.SelectedItem.ToString();
                string selectedCategory = categoryComboBox.SelectedItem.ToString();
                int categoryId = categoryDictionary[selectedCategory];
                string preference = yesRadioButton.Checked ? "yes" : "no";

                string updateQuery = "UPDATE items SET name = @name, expiration_date = @expiration_date, unit_price = @unit_price, " +
                                 "quantity = @quantity, health_star_rating = @health_star_rating, category_id = @category_id, " +
                                 "preference = @preference, updated_at = CURRENT_TIMESTAMP WHERE id = @id AND user_id = @user_id";

                DatabaseManager.Instance.ExecuteNonQuery(updateQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@expiration_date", expirationDate);
                    cmd.Parameters.AddWithValue("@unit_price", unitPrice);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@health_star_rating", healthStarRating);
                    cmd.Parameters.AddWithValue("@category_id", categoryId);
                    cmd.Parameters.AddWithValue("@preference", preference);
                    cmd.Parameters.AddWithValue("@id", itemId);
                    cmd.Parameters.AddWithValue("@user_id", SessionManager.UserId);
                });

                if (preference == "yes")
            {
                AddToPreferencesIfNotExists(itemName);
            }

            AddOrUpdateConsumption();
            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ItemUpdated?.Invoke();
            this.Close();

            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM items WHERE id = @id AND user_id = @user_id";
                DatabaseManager.Instance.ExecuteNonQuery(deleteQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", itemId);
                    cmd.Parameters.AddWithValue("@user_id", SessionManager.UserId);
                });

                AddOrUpdateConsumption();
                MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ItemUpdated?.Invoke();
                this.Close();
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool allItemListFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is AllItemsList AllItemListForm)
                {
                    
                    AllItemListForm.Show();
                    AllItemListForm.BringToFront(); 
                    allItemListFormFound = true;
                    break;
                }
            }

            if (!allItemListFormFound)
            {
                AllItemsList allItemListForm = new AllItemsList();
                allItemListForm.Show();
            }
        }
    }
}
