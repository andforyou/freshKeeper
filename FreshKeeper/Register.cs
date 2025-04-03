using MySql.Data.MySqlClient;

namespace FreshKeeper
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = newUserTextBox.Text.Trim();
            string password = newPassTextBox.Text.Trim();
            string confirmPassword = confirmPassTextBox.Text.Trim();
            decimal height;
            decimal weight;
            int age;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(textHeightBox.Text) || string.IsNullOrWhiteSpace(textWeightBox.Text) || string.IsNullOrWhiteSpace(textAgeBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newPassTextBox.Clear();
                confirmPassTextBox.Clear();
                return;
            }

            // Validate and parse numeric input
            if (!decimal.TryParse(textHeightBox.Text, out height))
            {
                MessageBox.Show("Invalid height. Please enter a valid number.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textWeightBox.Text, out weight))
            {
                MessageBox.Show("Invalid weight. Please enter a valid number.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textAgeBox.Text, out age))
            {
                MessageBox.Show("Invalid age. Please enter a valid number.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string healthRequirement = comboBox1.SelectedItem?.ToString() ?? "Maintenance";

            // Check if the username already exists
            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newUserTextBox.Clear();
                return;
            }

            // Add the new user to the database
            if (AddUserToDatabase(username, password, height, weight, age, healthRequirement))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); 
            }
            else
            {
                MessageBox.Show("An error occurred while registering. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to add new users to the database
        private bool AddUserToDatabase(string username, string password, decimal height, decimal weight, int age, string healthRequirement)
        {
            string query = "INSERT INTO users (user_name, password, height, weight, age, body_index, health_requirement) " +
                       "VALUES (@user_name, @password, @height, @weight, @age, @bodyIndex, @healthRequirement)";

            try
            {
                DatabaseManager.Instance.ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@user_name", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@height", height);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@bodyIndex", CalculateBodyIndex(height, weight));
                    cmd.Parameters.AddWithValue("@healthRequirement", healthRequirement);
                });
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding user: {ex.Message}");
                return false;
            }
        }

        
        private decimal CalculateBodyIndex(decimal height, decimal weight)
        {
            // BMI
            return weight / ((height / 100) * (height / 100));
        }

        // Check if the username exists in the database
        private bool IsUsernameExists(string username)
        {
            bool exists = false;
            string query = "SELECT COUNT(1) FROM users WHERE user_name = @user_name";

            var result = DatabaseManager.Instance.ExecuteScalar(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@user_name", username);
            });

            if (result != null && Convert.ToInt32(result) > 0)
            {
                exists = true;
            }

            return exists;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Select a Profile Picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the profilePictureBox
                profilePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust the image size
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool loginFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is Login LoginForm)
                {
                    
                    LoginForm.Show();
                    LoginForm.BringToFront();
                    loginFormFound = true;
                    break;
                }
            }

            if (!loginFormFound)
            {
                Login newLoginForm = new Login();
                newLoginForm.Show();
            }
        }

    }
}
