namespace FreshKeeper
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            newUserTextBox = new TextBox();
            registerLabel = new Label();
            newPassTextBox = new TextBox();
            confirmPassTextBox = new TextBox();
            newUserLabel = new Label();
            confirmPassLabel = new Label();
            newPassLabel = new Label();
            submitButton = new Button();
            cancleButton = new Button();
            heightLable = new Label();
            textHeightBox = new TextBox();
            weightLabel = new Label();
            textWeightBox = new TextBox();
            ageLabel = new Label();
            textAgeBox = new TextBox();
            healthGoalLabel = new Label();
            comboBox1 = new ComboBox();
            cmlabel = new Label();
            kglabel = new Label();
            profilePictureBox = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            uploadButton = new Button();

            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.uploadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // newUserTextBox
            // 
            newUserTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserTextBox.ForeColor = Color.DarkGreen;
            newUserTextBox.Location = new Point(410, 89);
            newUserTextBox.Name = "newUserTextBox";
            newUserTextBox.Size = new Size(191, 27);
            newUserTextBox.TabIndex = 0;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.DarkOliveGreen;
            registerLabel.Location = new Point(55, 9);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(517, 52);
            registerLabel.TabIndex = 1;
            registerLabel.Text = "Register to Fresh Keeper";
            // 
            // newPassTextBox
            // 
            newPassTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPassTextBox.ForeColor = Color.DarkGreen;
            newPassTextBox.Location = new Point(410, 133);
            newPassTextBox.Name = "newPassTextBox";
            newPassTextBox.Size = new Size(191, 27);
            newPassTextBox.TabIndex = 2;
            // 
            // confirmPassTextBox
            // 
            confirmPassTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPassTextBox.ForeColor = Color.DarkGreen;
            confirmPassTextBox.Location = new Point(410, 179);
            confirmPassTextBox.Name = "confirmPassTextBox";
            confirmPassTextBox.Size = new Size(191, 27);
            confirmPassTextBox.TabIndex = 3;
            // 
            // newUserLabel
            // 
            newUserLabel.AutoSize = true;
            newUserLabel.Font = new Font("Arial", 10F);
            newUserLabel.ForeColor = Color.DarkGreen;
            newUserLabel.Location = new Point(309, 92);
            newUserLabel.Name = "newUserLabel";
            newUserLabel.Size = new Size(95, 19);
            newUserLabel.TabIndex = 4;
            newUserLabel.Text = "User Name:";
            // 
            // confirmPassLabel
            // 
            confirmPassLabel.AutoSize = true;
            confirmPassLabel.BackColor = Color.Transparent;
            confirmPassLabel.Font = new Font("Arial", 10F);
            confirmPassLabel.ForeColor = Color.DarkGreen;
            confirmPassLabel.Location = new Point(256, 182);
            confirmPassLabel.Name = "confirmPassLabel";
            confirmPassLabel.Size = new Size(148, 19);
            confirmPassLabel.TabIndex = 5;
            confirmPassLabel.Text = "Confirm Password:";
            // 
            // newPassLabel
            // 
            newPassLabel.AutoSize = true;
            newPassLabel.Font = new Font("Arial", 10F);
            newPassLabel.ForeColor = Color.DarkGreen;
            newPassLabel.Location = new Point(319, 136);
            newPassLabel.Name = "newPassLabel";
            newPassLabel.Size = new Size(85, 19);
            newPassLabel.TabIndex = 6;
            newPassLabel.Text = "Password:";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.OliveDrab;
            submitButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitButton.ForeColor = Color.GhostWhite;
            submitButton.Location = new Point(389, 430);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(183, 33);
            submitButton.TabIndex = 8;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // cancleButton
            // 
            cancleButton.BackColor = Color.FloralWhite;
            cancleButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancleButton.ForeColor = Color.DarkGreen;
            cancleButton.Location = new Point(55, 430);
            cancleButton.Name = "cancleButton";
            cancleButton.Size = new Size(183, 33);
            cancleButton.TabIndex = 9;
            cancleButton.Text = "Cancle";
            cancleButton.UseVisualStyleBackColor = false;
            cancleButton.Click += CancelButton_Click;
            // 
            // heightLable
            // 
            heightLable.AutoSize = true;
            heightLable.ForeColor = Color.DarkGreen;
            heightLable.Location = new Point(341, 229);
            heightLable.Name = "heightLable";
            heightLable.Size = new Size(63, 20);
            heightLable.TabIndex = 10;
            heightLable.Text = "Height:";
            // 
            // textHeightBox
            // 
            textHeightBox.Location = new Point(410, 226);
            textHeightBox.Name = "textHeightBox";
            textHeightBox.Size = new Size(191, 27);
            textHeightBox.TabIndex = 11;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.ForeColor = Color.DarkGreen;
            weightLabel.Location = new Point(338, 275);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(66, 20);
            weightLabel.TabIndex = 12;
            weightLabel.Text = "Weight:";
            // 
            // textWeightBox
            // 
            textWeightBox.Location = new Point(410, 272);
            textWeightBox.Name = "textWeightBox";
            textWeightBox.Size = new Size(191, 27);
            textWeightBox.TabIndex = 13;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.ForeColor = Color.DarkGreen;
            ageLabel.Location = new Point(361, 322);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(43, 20);
            ageLabel.TabIndex = 14;
            ageLabel.Text = "Age:";
            // 
            // textAgeBox
            // 
            textAgeBox.Location = new Point(410, 319);
            textAgeBox.Name = "textAgeBox";
            textAgeBox.Size = new Size(191, 27);
            textAgeBox.TabIndex = 15;
            // 
            // healthGoalLabel
            // 
            healthGoalLabel.AutoSize = true;
            healthGoalLabel.ForeColor = Color.DarkGreen;
            healthGoalLabel.Location = new Point(306, 369);
            healthGoalLabel.Name = "healthGoalLabel";
            healthGoalLabel.Size = new Size(98, 20);
            healthGoalLabel.TabIndex = 16;
            healthGoalLabel.Text = "Health Goal:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Weight Loss", "Weight Gain", "Muscle Gain", "Maintenance" });
            comboBox1.Location = new Point(410, 366);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 28);
            comboBox1.TabIndex = 17;
            // 
            // cmlabel
            // 
            cmlabel.AutoSize = true;
            cmlabel.BackColor = Color.White;
            cmlabel.ForeColor = SystemColors.ControlDarkDark;
            cmlabel.Location = new Point(557, 229);
            cmlabel.Name = "cmlabel";
            cmlabel.Size = new Size(41, 20);
            cmlabel.TabIndex = 18;
            cmlabel.Text = "(cm)";
            // 
            // kglabel
            // 
            kglabel.AutoSize = true;
            kglabel.BackColor = Color.White;
            kglabel.ForeColor = SystemColors.ControlDarkDark;
            kglabel.Location = new Point(561, 275);
            kglabel.Name = "kglabel";
            kglabel.Size = new Size(37, 20);
            kglabel.TabIndex = 19;
            kglabel.Text = "(kg)";
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackgroundImage = (Image)resources.GetObject("profilePictureBox.BackgroundImage");
            profilePictureBox.Location = new Point(28, 92);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(210, 210);
            profilePictureBox.TabIndex = 20;
            profilePictureBox.TabStop = false;
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; // 增加边框更美观
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            // 
            // uploadButton
            // 
            this.uploadButton = new System.Windows.Forms.Button();
            uploadButton.Location = new Point(28, 330);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(210, 34);
            uploadButton.TabIndex = 21;
            uploadButton.Text = "Upload Profile...";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(628, 484);
            Controls.Add(uploadButton);
            Controls.Add(profilePictureBox);
            Controls.Add(kglabel);
            Controls.Add(cmlabel);
            Controls.Add(comboBox1);
            Controls.Add(healthGoalLabel);
            Controls.Add(textAgeBox);
            Controls.Add(ageLabel);
            Controls.Add(textWeightBox);
            Controls.Add(weightLabel);
            Controls.Add(textHeightBox);
            Controls.Add(heightLable);
            Controls.Add(cancleButton);
            Controls.Add(submitButton);
            Controls.Add(newPassLabel);
            Controls.Add(confirmPassLabel);
            Controls.Add(newUserLabel);
            Controls.Add(confirmPassTextBox);
            Controls.Add(newPassTextBox);
            Controls.Add(registerLabel);
            Controls.Add(newUserTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            FormClosing += Register_FormClosing;
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newUserTextBox;
        private Label registerLabel;
        private TextBox newPassTextBox;
        private TextBox confirmPassTextBox;
        private Label newUserLabel;
        private Label confirmPassLabel;
        private Label newPassLabel;
        private Button submitButton;
        private Button cancleButton;
        private Label heightLable;
        private TextBox textHeightBox;
        private Label weightLabel;
        private TextBox textWeightBox;
        private Label ageLabel;
        private TextBox textAgeBox;
        private Label healthGoalLabel;
        private ComboBox comboBox1;
        private Label cmlabel;
        private Label kglabel;
        private PictureBox profilePictureBox;
        private OpenFileDialog openFileDialog1;
        private Button uploadButton;
    }
}