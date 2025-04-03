using MySql.Data.MySqlClient;
using static FreshKeeper.ItemDetails;

namespace FreshKeeper
{
    public partial class ItemUploading : Form
    {
        private Dictionary<string, int> categoryDictionary; // Storage class name and corresponding ID
        public event Action ItemAdded;

        public ItemUploading()
        {
            InitializeComponent();
            InitializeCategoryDictionary(); // Initialize categoryDictionary
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

        private void ClearInputFields()
        {
            foodNameTextBox.Clear();
            bestBeforeDateTimePicker.Value = DateTime.Now; // Reset date picker
            priceTextBox.Clear();
            quantityTextBox.Clear();
            healthStarRatingComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;
            yesRadioButton.Checked = false;
            noRadioButton.Checked = true; 
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (InputValidator.ValidateItemInput(foodNameTextBox.Text.Trim(), quantityTextBox.Text.Trim(), null, healthStarRatingComboBox, categoryComboBox))
            {
                string itemName = foodNameTextBox.Text.Trim();
                DateTime expirationDate = bestBeforeDateTimePicker.Value;
                float unitPrice = float.Parse(priceTextBox.Text);
                int quantity = int.Parse(quantityTextBox.Text);
                string healthStarRating = healthStarRatingComboBox.SelectedItem.ToString();
                string selectedCategory = categoryComboBox.SelectedItem.ToString();
                int categoryId = categoryDictionary[selectedCategory];
                string preference = yesRadioButton.Checked ? "yes" : "no";

                
                if (SaveFoodToDatabase(itemName, expirationDate, unitPrice, quantity, healthStarRating, categoryId, preference))
                {
                    MessageBox.Show("Food item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    ItemAdded?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the item. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveFoodToDatabase(string name, DateTime expirationDate, float unitPrice, int quantity, string healthStarRating, int categoryId, string preference)
        {
            string query = "INSERT INTO items (user_id, name, expiration_date, category_id, quantity, health_star_rating, preference, created_at, updated_at, unit_price) " +
                        "VALUES (@user_id, @name, @expiration_date, @category_id, @quantity, @health_star_rating, @preference, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, @unit_price)";

            int rowsAffected = DatabaseManager.Instance.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@user_id", SessionManager.UserId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@expiration_date", expirationDate);
                cmd.Parameters.AddWithValue("@category_id", categoryId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@health_star_rating", healthStarRating);
                cmd.Parameters.AddWithValue("@preference", preference);
                cmd.Parameters.AddWithValue("@unit_price", unitPrice);
            });

            if (rowsAffected > 0)
            {
                // If preference is "yes", add to the preferences table
                if (preference.ToLower() == "yes")
                {
                    AddToPreferences(name);
                }
                return true;
            }
            return false;
        }

        private void AddToPreferences(string itemName)
        {
            string checkQuery = "SELECT COUNT(*) FROM preferences WHERE user_id = @user_id AND item_name = @item_name";
            var countResult = DatabaseManager.Instance.ExecuteScalar(checkQuery, cmd =>
            {
                cmd.Parameters.AddWithValue("@user_id", SessionManager.UserId);
                cmd.Parameters.AddWithValue("@item_name", itemName);
            });

            int count = Convert.ToInt32(countResult);
            if (count == 0) // If the item does not exist in the preference table, insert it
            {
                string insertQuery = "INSERT INTO preferences (user_id, item_name, created_at, updated_at) VALUES (@user_id, @item_name, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)";
                DatabaseManager.Instance.ExecuteNonQuery(insertQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@user_id", SessionManager.UserId);
                    cmd.Parameters.AddWithValue("@item_name", itemName);
                });
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemUploading_FormClosing(object sender, FormClosingEventArgs e)
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
