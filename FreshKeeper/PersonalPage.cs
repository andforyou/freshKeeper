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
    public partial class PersonalPage : Form
    {
        private bool isClosingManully = false;

        public PersonalPage()
        {
            InitializeComponent();
            LoadPersonalInformation();
            LoadWeeklyConsumption();
            LoadSuggestions();
        }

        // Load user personal information
        private void LoadPersonalInformation()
        {
            string query = "SELECT user_name, height, weight, age, health_requirement, body_index FROM users WHERE user_id = @userId";

            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            if (results.Count > 0)
            {
                var row = results[0];
                userNameTextBox.Text = row["user_name"].ToString();
                heightTextBox.Text = Convert.ToDecimal(row["height"]).ToString();
                weightTextBox.Text = Convert.ToDecimal(row["weight"]).ToString();
                ageTextBox.Text = Convert.ToInt32(row["age"]).ToString();
                healthGoalTextBox.Text = row["health_requirement"].ToString();
                bmiTextBox.Text = Convert.ToDecimal(row["body_index"]).ToString("F2");
            }
            else
            {
                MessageBox.Show("No personal information found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load this week's consumption records
        private void LoadWeeklyConsumption()
        {
            consumptionListBox.Items.Clear();

            string query = "SELECT item_name, con_quantity, amount_spent FROM consumption WHERE user_id = @userId";

            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            foreach (var row in results)
            {
                string itemName = row["item_name"].ToString();
                int quantity = Convert.ToInt32(row["con_quantity"]);
                decimal amountSpent = Convert.ToDecimal(row["amount_spent"]);

                string displayText = $"{itemName},    {quantity},    {amountSpent:C}";
                consumptionListBox.Items.Add(displayText);
            }
        }

        // Load this week's consumption suggestions
        private void LoadSuggestions()
        {
            suggestionListBox.Items.Clear();

            string query = "SELECT " +
                       "(SELECT SUM(con_quantity) FROM consumption WHERE health_star_rating IN ('4', '5') AND user_id = @userId) AS healthyQuantity, " +
                       "(SELECT SUM(con_quantity) FROM consumption WHERE health_star_rating IN ('1', '2', '3') AND user_id = @userId) AS unhealthyQuantity";

            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            if (results.Count > 0)
            {
                var row = results[0];
                int healthyQuantity = row["healthyQuantity"] != DBNull.Value ? Convert.ToInt32(row["healthyQuantity"]) : 0;
                int unhealthyQuantity = row["unhealthyQuantity"] != DBNull.Value ? Convert.ToInt32(row["unhealthyQuantity"]) : 0;

                // Give suggestions based on quantity comparison
                string suggestion;
                if (healthyQuantity > unhealthyQuantity)
                {
                    suggestion = "Great job! You're consuming more healthy options with high health star ratings. Keep it up!";
                }
                else if (healthyQuantity < unhealthyQuantity)
                {
                    suggestion = "Warning: You have consumed more items with low health star ratings. Consider choosing healthier options.";
                }
                else
                {
                    suggestion = "You're doing okay. You have an equal balance of healthy and unhealthy items. Try to choose more healthy options next time.";
                }

                suggestionListBox.Items.Add(suggestion);
            }
            else
            {
                MessageBox.Show("No health star data found for this user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void preferenceListButton_Click(object sender, EventArgs e)
        {
            PreferenceList checkPreferendeListForm = new PreferenceList();
            checkPreferendeListForm.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            bool loginFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is Login LoginForm)
                {
                    // If an existing Login form is found, display it
                    LoginForm.Show();
                    LoginForm.BringToFront(); 
                    loginFormFound = true;
                    isClosingManully = true;
                    this.Close();
                    break;
                }
            }

            if (!loginFormFound)
            {
                Login newLoginForm = new Login();
                newLoginForm.Show();
                this.Close();
            }
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            StatisticChart statisticForm = new StatisticChart();
            statisticForm.Show();
            this.Hide();
        }

        private void PersonalPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClosingManully == false)
            {
                bool dashBoardFormFound = false;

                foreach (Form form in Application.OpenForms)
                {
                    if (form is DashBoard DashBoardForm)
                    {
                        // If an existing Login form is found, display it
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
}
