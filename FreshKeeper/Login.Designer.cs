namespace FreshKeeper
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            welcomeLabel = new Label();
            loginLogo = new PictureBox();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            userNameLabel = new Label();
            passwordLabel = new Label();
            signUpButton = new Button();
            loginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)loginLogo).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.DarkGreen;
            welcomeLabel.Location = new Point(9, 3);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(537, 52);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to Fresh Keeper";
            // 
            // loginLogo
            // 
            loginLogo.BackColor = Color.Transparent;
            loginLogo.Image = (Image)resources.GetObject("loginLogo.Image");
            loginLogo.Location = new Point(0, 39);
            loginLogo.Name = "loginLogo";
            loginLogo.Size = new Size(305, 298);
            loginLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            loginLogo.TabIndex = 1;
            loginLogo.TabStop = false;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.ForeColor = Color.DarkGreen;
            userNameTextBox.Location = new Point(400, 102);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(125, 27);
            userNameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.DarkGreen;
            passwordTextBox.Location = new Point(400, 178);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.DarkGreen;
            userNameLabel.Location = new Point(299, 105);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(95, 19);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.DarkGreen;
            passwordLabel.Location = new Point(309, 181);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(85, 19);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FloralWhite;
            signUpButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpButton.ForeColor = Color.DarkGreen;
            signUpButton.Location = new Point(288, 262);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(94, 29);
            signUpButton.TabIndex = 6;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LimeGreen;
            loginButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.FloralWhite;
            loginButton.Location = new Point(431, 262);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(556, 338);
            Controls.Add(loginButton);
            Controls.Add(signUpButton);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(welcomeLabel);
            Controls.Add(loginLogo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)loginLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private PictureBox loginLogo;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label userNameLabel;
        private Label passwordLabel;
        private Button signUpButton;
        private Button loginButton;
    }
}
