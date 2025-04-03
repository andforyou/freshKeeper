namespace FreshKeeper
{
    partial class ItemDetails
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
            backButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            itemNameLabel = new Label();
            expireDateLabel = new Label();
            unitPriceLabel = new Label();
            quantityLabel = new Label();
            healthStarRatingLabel = new Label();
            categoryLabel = new Label();
            itemNameTextBox = new TextBox();
            bestBeforeDateTimePicker = new DateTimePicker();
            unitPriceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            healthStarRatingComboBox = new ComboBox();
            categoryComboBox = new ComboBox();
            preferenceLabel = new Label();
            yesRadioButton = new RadioButton();
            noRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.FloralWhite;
            backButton.Font = new Font("Microsoft YaHei UI", 9F);
            backButton.ForeColor = Color.DimGray;
            backButton.Location = new Point(360, 335);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 3;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FloralWhite;
            deleteButton.Font = new Font("Microsoft YaHei UI", 9F);
            deleteButton.ForeColor = Color.Brown;
            deleteButton.Location = new Point(40, 335);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.ForeColor = Color.DarkOliveGreen;
            updateButton.Location = new Point(196, 335);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new Font("Microsoft YaHei UI", 9F);
            itemNameLabel.Location = new Point(92, 25);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(93, 20);
            itemNameLabel.TabIndex = 7;
            itemNameLabel.Text = "Item Name:";
            // 
            // expireDateLabel
            // 
            expireDateLabel.AutoSize = true;
            expireDateLabel.Font = new Font("Microsoft YaHei UI", 9F);
            expireDateLabel.Location = new Point(89, 70);
            expireDateLabel.Name = "expireDateLabel";
            expireDateLabel.Size = new Size(96, 20);
            expireDateLabel.TabIndex = 8;
            expireDateLabel.Text = "Best Before:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Font = new Font("Microsoft YaHei UI", 9F);
            unitPriceLabel.Location = new Point(102, 112);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new Size(83, 20);
            unitPriceLabel.TabIndex = 9;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Microsoft YaHei UI", 9F);
            quantityLabel.Location = new Point(110, 152);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(75, 20);
            quantityLabel.TabIndex = 10;
            quantityLabel.Text = "Quantity:";
            // 
            // healthStarRatingLabel
            // 
            healthStarRatingLabel.AutoSize = true;
            healthStarRatingLabel.Font = new Font("Microsoft YaHei UI", 9F);
            healthStarRatingLabel.Location = new Point(40, 194);
            healthStarRatingLabel.Name = "healthStarRatingLabel";
            healthStarRatingLabel.Size = new Size(145, 20);
            healthStarRatingLabel.TabIndex = 11;
            healthStarRatingLabel.Text = "Health Star Rating:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Microsoft YaHei UI", 9F);
            categoryLabel.Location = new Point(105, 240);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(80, 20);
            categoryLabel.TabIndex = 12;
            categoryLabel.Text = "Category:";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(191, 22);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(125, 27);
            itemNameTextBox.TabIndex = 13;
            // 
            // bestBeforeDateTimePicker
            // 
            bestBeforeDateTimePicker.Location = new Point(191, 65);
            bestBeforeDateTimePicker.Name = "bestBeforeDateTimePicker";
            bestBeforeDateTimePicker.Size = new Size(263, 27);
            bestBeforeDateTimePicker.TabIndex = 14;
            // 
            // unitPriceTextBox
            // 
            unitPriceTextBox.Location = new Point(191, 109);
            unitPriceTextBox.Name = "unitPriceTextBox";
            unitPriceTextBox.Size = new Size(151, 27);
            unitPriceTextBox.TabIndex = 15;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(191, 149);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(151, 27);
            quantityTextBox.TabIndex = 16;
            // 
            // healthStarRatingComboBox
            // 
            healthStarRatingComboBox.FormattingEnabled = true;
            healthStarRatingComboBox.Items.AddRange(new object[] { "5", "4", "3", "2", "1" });
            healthStarRatingComboBox.Location = new Point(191, 191);
            healthStarRatingComboBox.Name = "healthStarRatingComboBox";
            healthStarRatingComboBox.Size = new Size(151, 28);
            healthStarRatingComboBox.TabIndex = 17;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Proteins", "Carbohydrates", "Fats", "Dairy", "Vegetables", "Fruits", "Grains", "Sugars", "Beverages", "Seafood", "Snacks", "Legumes", "Nuts and Seeds", "Sweets and Desserts", "Baked Goods", "Condiments and Sauces", "Processed Foods", "Herbal and Spices", "Oils", "Alcoholic Beverages", "Non-Alcoholic Beverages" });
            categoryComboBox.Location = new Point(191, 237);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(151, 28);
            categoryComboBox.TabIndex = 18;
            // 
            // preferenceLabel
            // 
            preferenceLabel.AutoSize = true;
            preferenceLabel.Font = new Font("Microsoft YaHei UI", 9F);
            preferenceLabel.Location = new Point(93, 284);
            preferenceLabel.Name = "preferenceLabel";
            preferenceLabel.Size = new Size(92, 20);
            preferenceLabel.TabIndex = 19;
            preferenceLabel.Text = "Preference:";
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Location = new Point(196, 282);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(55, 24);
            yesRadioButton.TabIndex = 20;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(290, 282);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(52, 24);
            noRadioButton.TabIndex = 21;
            noRadioButton.TabStop = true;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            // 
            // ItemDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(498, 382);
            Controls.Add(noRadioButton);
            Controls.Add(yesRadioButton);
            Controls.Add(preferenceLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(healthStarRatingComboBox);
            Controls.Add(quantityTextBox);
            Controls.Add(unitPriceTextBox);
            Controls.Add(bestBeforeDateTimePicker);
            Controls.Add(itemNameTextBox);
            Controls.Add(categoryLabel);
            Controls.Add(healthStarRatingLabel);
            Controls.Add(quantityLabel);
            Controls.Add(unitPriceLabel);
            Controls.Add(expireDateLabel);
            Controls.Add(itemNameLabel);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ItemDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Details";
            FormClosing += ItemDetails_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backButton;
        private Button deleteButton;
        private Button updateButton;
        private Label itemNameLabel;
        private Label expireDateLabel;
        private Label unitPriceLabel;
        private Label quantityLabel;
        private Label healthStarRatingLabel;
        private Label categoryLabel;
        private TextBox itemNameTextBox;
        private DateTimePicker bestBeforeDateTimePicker;
        private TextBox unitPriceTextBox;
        private TextBox quantityTextBox;
        private ComboBox healthStarRatingComboBox;
        private ComboBox categoryComboBox;
        private Label preferenceLabel;
        private RadioButton yesRadioButton;
        private RadioButton noRadioButton;
    }
}