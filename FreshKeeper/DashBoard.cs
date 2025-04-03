using MySql.Data.MySqlClient;
using static FreshKeeper.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FreshKeeper
{
    public partial class DashBoard : Form
    {
        private Dictionary<string, Tuple<DateTime, int>> itemDatabase = new Dictionary<string, Tuple<DateTime, int>>();

        private string _userName; // Store login username
        private bool isclosing = true;

        public DashBoard(string userName)
        {
            InitializeComponent();
            _userName = userName;
            userNameLinkLabel.Text = $"{_userName}, Welcome!"; 
            InitializeFoodDatabase();
            PopulateListBoxes();
        }

        private void InitializeFoodDatabase()
        {
            itemDatabase.Clear();

            string query = "SELECT name, expiration_date, quantity FROM items WHERE user_id = @user_id";

            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@user_id", SessionManager.UserId);
            });

            foreach (var row in results)
            {
                string name = row["name"].ToString();
                DateTime expirationDate = (DateTime)row["expiration_date"];
                int quantity = Convert.ToInt32(row["quantity"]);
                itemDatabase[name] = Tuple.Create(expirationDate, quantity);
            }
        }

        private void PopulateListBoxes()
        {
            oneDayListBox.Items.Clear();
            oneWeekListBox.Items.Clear();

            foreach (var food in itemDatabase)
            {
                string itemName = food.Key;
                DateTime expirationDate = food.Value.Item1;
                int quantity = food.Value.Item2;
                TimeSpan timeUntilExpiry = expirationDate - DateTime.Now;

                string displayText = $"{itemName}:     {quantity}";

                if (timeUntilExpiry.TotalDays <= 1)
                {
                    oneDayListBox.Items.Add(displayText);
                }
                else if (timeUntilExpiry.TotalDays <= 7)
                {
                    oneWeekListBox.Items.Add(displayText);
                }
            }
        }

        private void allItemsButton_Click(object sender, EventArgs e)
        {
            AllItemsList allItemsForm = new AllItemsList();
            allItemsForm.Show();
            isclosing = false;
            this.Close();
        }

        private void shoppingListButton_Click(object sender, EventArgs e)
        {
            ShoppingList shoppingListForm = new ShoppingList();
            shoppingListForm.Show();
            this.Hide();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            ItemUploading addItemForm = new ItemUploading();
            addItemForm.Show();
            isclosing = false;
            this.Close();
        }

        private void userNameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonalPage personalPageForm = new PersonalPage();
            personalPageForm.Show();
            this.Hide();
        } 

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isclosing == true)
            {
                var openForms = Application.OpenForms.Cast<Form>().Where(f => f != this).ToList();

                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel close event
                }
                else
                {
                    if (openForms.Any())
                    {
                        Application.ExitThread(); // Close all other windows
                    }
                    else
                    {
                        Application.Exit(); //Close the entire application
                    }
                }
            }
        }
    }
}
