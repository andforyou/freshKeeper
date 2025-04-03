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
    public partial class ShoppingList : Form
    {
        public ShoppingList()
        {
            InitializeComponent();
            LoadShoppingList();
        }

        private void LoadShoppingList()
        {
            
            shoppingListCheckedListBox.Items.Clear();

            // Query the items in the user's preference table
            string preferenceQuery = "SELECT item_name FROM preferences WHERE user_id = @userId";
            var preferenceResults = DatabaseManager.Instance.ExecuteReader(preferenceQuery, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            List<string> preferenceItems = new List<string>();
            foreach (var row in preferenceResults)
            {
                string itemName = row["item_name"].ToString();
                preferenceItems.Add(itemName);
            }

            // Query the current user's items in the items table
            string itemsQuery = "SELECT name, quantity, unit_price FROM items WHERE user_id = @userId";
            var itemsResults = DatabaseManager.Instance.ExecuteReader(itemsQuery, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            Dictionary<string, Tuple<int, float>> itemsDictionary = new Dictionary<string, Tuple<int, float>>();
            foreach (var row in itemsResults)
            {
                string itemName = row["name"].ToString();
                int quantity = Convert.ToInt32(row["quantity"]);
                float unitPrice = Convert.ToSingle(row["unit_price"]);
                itemsDictionary[itemName] = Tuple.Create(quantity, unitPrice);
            }

            // Display the items in the preference table but not in the items table in the list box
            foreach (string preferenceItem in preferenceItems)
            {
                if (!itemsDictionary.ContainsKey(preferenceItem))
                {
                    shoppingListCheckedListBox.Items.Add(preferenceItem);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShoppingList_FormClosing(object sender, FormClosingEventArgs e)
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
