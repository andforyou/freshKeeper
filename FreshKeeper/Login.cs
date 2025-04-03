using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FreshKeeper
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Use MySQL database for user authentication
        private bool AuthenticateUser(string username, string password, out int userId, out string userName)
        {
            bool isAuthenticated = false;
            userId = -1;
            userName = string.Empty;

            string query = "SELECT user_id, user_name FROM users WHERE user_name = @user_name AND password = @password";
            var result = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@user_name", username);
                cmd.Parameters.AddWithValue("@password", password);
            });

            if (result.Count > 0)
            {
                userId = Convert.ToInt32(result[0]["user_id"]);
                userName = result[0]["user_name"].ToString();
                isAuthenticated = true;
            }

            return isAuthenticated;
        }

        // Click the "Register" button to open the registration window
        private void signUpButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        // Click the "Login" button to authenticate the user and open the dashboard
        public void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            int userId;
            string userName;

            if (AuthenticateUser(username, password, out userId, out userName))
            {
                SessionManager.InitializeSession(userId, userName);
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashBoard dashboardForm = new DashBoard(userName);
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            var openForms = Application.OpenForms.Cast<Form>().Where(f => f != this).ToList();

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
            else
            {
                if (openForms.Any())
                {
                    Application.ExitThread(); 
                }
                else
                {
                    Application.Exit(); 
                }
            }
        }

    }
}
