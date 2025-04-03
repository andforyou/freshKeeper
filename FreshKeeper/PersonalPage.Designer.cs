namespace FreshKeeper
{
    partial class PersonalPage
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
            infroLabel = new Label();
            consumptionLabel = new Label();
            suggestionLabel = new Label();
            suggestionListBox = new ListBox();
            logOutButton = new Button();
            checkPreferenceButton = new Button();
            personalInforGroupBox = new GroupBox();
            kgLabel = new Label();
            cmLabel = new Label();
            healthGoalTextBox = new TextBox();
            healthGoalLabel = new Label();
            weightTextBox = new TextBox();
            weightLabel = new Label();
            heightTextBox = new TextBox();
            heightLabel = new Label();
            bmiTextBox = new TextBox();
            bmilabel = new Label();
            ageTextBox = new TextBox();
            ageLabel = new Label();
            userNameTextBox = new TextBox();
            NameLabel = new Label();
            consumptionListBox = new ListBox();
            consumptionGroupBox = new GroupBox();
            suggestionGroupBox = new GroupBox();
            statisticButton = new Button();
            personalInforGroupBox.SuspendLayout();
            consumptionGroupBox.SuspendLayout();
            suggestionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // infroLabel
            // 
            infroLabel.AutoSize = true;
            infroLabel.Location = new Point(29, 30);
            infroLabel.Name = "infroLabel";
            infroLabel.Size = new Size(175, 20);
            infroLabel.TabIndex = 1;
            infroLabel.Text = "Personal Information：";
            // 
            // consumptionLabel
            // 
            consumptionLabel.AutoSize = true;
            consumptionLabel.Location = new Point(6, 0);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(179, 20);
            consumptionLabel.TabIndex = 3;
            consumptionLabel.Text = "Weekly Consumption：";
            // 
            // suggestionLabel
            // 
            suggestionLabel.AutoSize = true;
            suggestionLabel.Location = new Point(6, 0);
            suggestionLabel.Name = "suggestionLabel";
            suggestionLabel.Size = new Size(107, 20);
            suggestionLabel.TabIndex = 5;
            suggestionLabel.Text = "Suggestion：";
            // 
            // suggestionListBox
            // 
            suggestionListBox.FormattingEnabled = true;
            suggestionListBox.Location = new Point(37, 445);
            suggestionListBox.Name = "suggestionListBox";
            suggestionListBox.Size = new Size(705, 64);
            suggestionListBox.TabIndex = 6;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(665, 553);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(94, 29);
            logOutButton.TabIndex = 7;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // checkPreferenceButton
            // 
            checkPreferenceButton.Location = new Point(23, 553);
            checkPreferenceButton.Name = "checkPreferenceButton";
            checkPreferenceButton.Size = new Size(149, 29);
            checkPreferenceButton.TabIndex = 8;
            checkPreferenceButton.Text = "Preference List";
            checkPreferenceButton.UseVisualStyleBackColor = true;
            checkPreferenceButton.Click += preferenceListButton_Click;
            // 
            // personalInforGroupBox
            // 
            personalInforGroupBox.Controls.Add(kgLabel);
            personalInforGroupBox.Controls.Add(cmLabel);
            personalInforGroupBox.Controls.Add(healthGoalTextBox);
            personalInforGroupBox.Controls.Add(healthGoalLabel);
            personalInforGroupBox.Controls.Add(weightTextBox);
            personalInforGroupBox.Controls.Add(weightLabel);
            personalInforGroupBox.Controls.Add(heightTextBox);
            personalInforGroupBox.Controls.Add(heightLabel);
            personalInforGroupBox.Controls.Add(bmiTextBox);
            personalInforGroupBox.Controls.Add(bmilabel);
            personalInforGroupBox.Controls.Add(ageTextBox);
            personalInforGroupBox.Controls.Add(ageLabel);
            personalInforGroupBox.Controls.Add(userNameTextBox);
            personalInforGroupBox.Controls.Add(NameLabel);
            personalInforGroupBox.Location = new Point(23, 30);
            personalInforGroupBox.Name = "personalInforGroupBox";
            personalInforGroupBox.Size = new Size(736, 140);
            personalInforGroupBox.TabIndex = 9;
            personalInforGroupBox.TabStop = false;
            personalInforGroupBox.Text = "groupBox1";
            // 
            // kgLabel
            // 
            kgLabel.AutoSize = true;
            kgLabel.BackColor = SystemColors.Control;
            kgLabel.ForeColor = SystemColors.ControlDarkDark;
            kgLabel.Location = new Point(487, 91);
            kgLabel.Name = "kgLabel";
            kgLabel.Size = new Size(37, 20);
            kgLabel.TabIndex = 13;
            kgLabel.Text = "(kg)";
            // 
            // cmLabel
            // 
            cmLabel.AutoSize = true;
            cmLabel.BackColor = SystemColors.Control;
            cmLabel.ForeColor = SystemColors.ControlDarkDark;
            cmLabel.Location = new Point(222, 90);
            cmLabel.Name = "cmLabel";
            cmLabel.Size = new Size(41, 20);
            cmLabel.TabIndex = 12;
            cmLabel.Text = "(cm)";
            // 
            // healthGoalTextBox
            // 
            healthGoalTextBox.Location = new Point(388, 37);
            healthGoalTextBox.Name = "healthGoalTextBox";
            healthGoalTextBox.ReadOnly = true;
            healthGoalTextBox.Size = new Size(139, 27);
            healthGoalTextBox.TabIndex = 11;
            // 
            // healthGoalLabel
            // 
            healthGoalLabel.AutoSize = true;
            healthGoalLabel.Location = new Point(287, 40);
            healthGoalLabel.Name = "healthGoalLabel";
            healthGoalLabel.Size = new Size(98, 20);
            healthGoalLabel.TabIndex = 10;
            healthGoalLabel.Text = "Health Goal:";
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(388, 87);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.ReadOnly = true;
            weightTextBox.Size = new Size(139, 27);
            weightTextBox.TabIndex = 9;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(316, 90);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(66, 20);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "Weight:";
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(140, 88);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.ReadOnly = true;
            heightTextBox.Size = new Size(127, 27);
            heightTextBox.TabIndex = 7;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(71, 91);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(63, 20);
            heightLabel.TabIndex = 6;
            heightLabel.Text = "Heigth:";
            // 
            // bmiTextBox
            // 
            bmiTextBox.Location = new Point(609, 37);
            bmiTextBox.Name = "bmiTextBox";
            bmiTextBox.ReadOnly = true;
            bmiTextBox.Size = new Size(74, 27);
            bmiTextBox.TabIndex = 5;
            // 
            // bmilabel
            // 
            bmilabel.AutoSize = true;
            bmilabel.Location = new Point(562, 40);
            bmilabel.Name = "bmilabel";
            bmilabel.Size = new Size(41, 20);
            bmilabel.TabIndex = 4;
            bmilabel.Text = "BMI:";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(609, 91);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.ReadOnly = true;
            ageTextBox.Size = new Size(74, 27);
            ageTextBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(560, 94);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(43, 20);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "Age:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(140, 37);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.ReadOnly = true;
            userNameTextBox.Size = new Size(127, 27);
            userNameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(41, 40);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(93, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "User Name:";
            // 
            // consumptionListBox
            // 
            consumptionListBox.FormattingEnabled = true;
            consumptionListBox.Location = new Point(14, 25);
            consumptionListBox.Name = "consumptionListBox";
            consumptionListBox.Size = new Size(705, 164);
            consumptionListBox.TabIndex = 10;
            // 
            // consumptionGroupBox
            // 
            consumptionGroupBox.Controls.Add(consumptionListBox);
            consumptionGroupBox.Controls.Add(consumptionLabel);
            consumptionGroupBox.Location = new Point(23, 191);
            consumptionGroupBox.Name = "consumptionGroupBox";
            consumptionGroupBox.Size = new Size(736, 203);
            consumptionGroupBox.TabIndex = 11;
            consumptionGroupBox.TabStop = false;
            // 
            // suggestionGroupBox
            // 
            suggestionGroupBox.Controls.Add(suggestionLabel);
            suggestionGroupBox.Location = new Point(23, 417);
            suggestionGroupBox.Name = "suggestionGroupBox";
            suggestionGroupBox.Size = new Size(736, 103);
            suggestionGroupBox.TabIndex = 12;
            suggestionGroupBox.TabStop = false;
            // 
            // statisticButton
            // 
            statisticButton.Location = new Point(310, 553);
            statisticButton.Name = "statisticButton";
            statisticButton.Size = new Size(201, 27);
            statisticButton.TabIndex = 13;
            statisticButton.Text = "Statistic";
            statisticButton.UseVisualStyleBackColor = true;
            statisticButton.Click += statisticButton_Click;
            // 
            // PersonalPage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 598);
            Controls.Add(statisticButton);
            Controls.Add(checkPreferenceButton);
            Controls.Add(logOutButton);
            Controls.Add(suggestionListBox);
            Controls.Add(infroLabel);
            Controls.Add(personalInforGroupBox);
            Controls.Add(consumptionGroupBox);
            Controls.Add(suggestionGroupBox);
            Name = "PersonalPage";
            Text = "Personal Page";
            FormClosing += PersonalPage_FormClosing;
            personalInforGroupBox.ResumeLayout(false);
            personalInforGroupBox.PerformLayout();
            consumptionGroupBox.ResumeLayout(false);
            consumptionGroupBox.PerformLayout();
            suggestionGroupBox.ResumeLayout(false);
            suggestionGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label infroLabel;
        private Label consumptionLabel;
        private Label suggestionLabel;
        private ListBox suggestionListBox;
        private Button logOutButton;
        private Button checkPreferenceButton;
        private GroupBox personalInforGroupBox;
        private TextBox userNameTextBox;
        private Label NameLabel;
        private TextBox bmiTextBox;
        private Label bmilabel;
        private TextBox ageTextBox;
        private Label ageLabel;
        private TextBox heightTextBox;
        private Label heightLabel;
        private TextBox healthGoalTextBox;
        private Label healthGoalLabel;
        private TextBox weightTextBox;
        private Label weightLabel;
        private Label cmLabel;
        private Label kgLabel;
        private ListBox consumptionListBox;
        private GroupBox consumptionGroupBox;
        private GroupBox suggestionGroupBox;
        private Button statisticButton;
    }
}