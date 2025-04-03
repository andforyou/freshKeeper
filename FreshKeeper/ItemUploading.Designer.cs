namespace FreshKeeper
{
    partial class ItemUploading
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
            foodNameTextBox = new TextBox();
            itemNameLabel = new Label();
            quanityLabel = new Label();
            unitPriceLabel = new Label();
            expireDateLabel = new Label();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            healthStarRatingLabel = new Label();
            healthStarRatingComboBox = new ComboBox();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            bestBeforeDateTimePicker = new DateTimePicker();
            preferenceLabel = new Label();
            yesRadioButton = new RadioButton();
            noRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // foodNameTextBox
            // 
            foodNameTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodNameTextBox.ForeColor = Color.DarkGreen;
            foodNameTextBox.Location = new Point(208, 34);
            foodNameTextBox.Name = "foodNameTextBox";
            foodNameTextBox.Size = new Size(195, 27);
            foodNameTextBox.TabIndex = 0;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.BackColor = Color.Transparent;
            itemNameLabel.Font = new Font("Microsoft YaHei UI", 9F);
            itemNameLabel.ForeColor = Color.DarkGreen;
            itemNameLabel.Location = new Point(110, 37);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(93, 20);
            itemNameLabel.TabIndex = 2;
            itemNameLabel.Text = "Item Name:";
            // 
            // quanityLabel
            // 
            quanityLabel.AutoSize = true;
            quanityLabel.BackColor = Color.Transparent;
            quanityLabel.Font = new Font("Microsoft YaHei UI", 9F);
            quanityLabel.ForeColor = Color.DarkGreen;
            quanityLabel.Location = new Point(128, 183);
            quanityLabel.Name = "quanityLabel";
            quanityLabel.Size = new Size(75, 20);
            quanityLabel.TabIndex = 3;
            quanityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.BackColor = Color.Transparent;
            unitPriceLabel.Font = new Font("Microsoft YaHei UI", 9F);
            unitPriceLabel.ForeColor = Color.DarkGreen;
            unitPriceLabel.Location = new Point(116, 137);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new Size(83, 20);
            unitPriceLabel.TabIndex = 4;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // expireDateLabel
            // 
            expireDateLabel.AutoSize = true;
            expireDateLabel.BackColor = Color.Transparent;
            expireDateLabel.Font = new Font("Microsoft YaHei UI", 9F);
            expireDateLabel.ForeColor = Color.DarkGreen;
            expireDateLabel.Location = new Point(102, 89);
            expireDateLabel.Name = "expireDateLabel";
            expireDateLabel.Size = new Size(96, 20);
            expireDateLabel.TabIndex = 5;
            expireDateLabel.Text = "Best Before:";
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTextBox.ForeColor = Color.DarkGreen;
            priceTextBox.Location = new Point(208, 129);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(195, 27);
            priceTextBox.TabIndex = 7;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityTextBox.ForeColor = Color.DarkGreen;
            quantityTextBox.Location = new Point(208, 180);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(195, 27);
            quantityTextBox.TabIndex = 8;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LimeGreen;
            saveButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.FloralWhite;
            saveButton.Location = new Point(309, 389);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 14;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FloralWhite;
            cancelButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.DimGray;
            cancelButton.Location = new Point(118, 389);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // healthStarRatingLabel
            // 
            healthStarRatingLabel.AutoSize = true;
            healthStarRatingLabel.Font = new Font("Microsoft YaHei UI", 9F);
            healthStarRatingLabel.ForeColor = Color.DarkGreen;
            healthStarRatingLabel.Location = new Point(57, 232);
            healthStarRatingLabel.Name = "healthStarRatingLabel";
            healthStarRatingLabel.Size = new Size(145, 20);
            healthStarRatingLabel.TabIndex = 16;
            healthStarRatingLabel.Text = "Health Star Rating:";
            // 
            // healthStarRatingComboBox
            // 
            healthStarRatingComboBox.FormattingEnabled = true;
            healthStarRatingComboBox.Items.AddRange(new object[] { "5", "4", "3", "2", "1" });
            healthStarRatingComboBox.Location = new Point(208, 228);
            healthStarRatingComboBox.Name = "healthStarRatingComboBox";
            healthStarRatingComboBox.Size = new Size(195, 28);
            healthStarRatingComboBox.TabIndex = 17;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Microsoft YaHei UI", 9F);
            categoryLabel.ForeColor = Color.DarkGreen;
            categoryLabel.Location = new Point(121, 280);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(80, 20);
            categoryLabel.TabIndex = 18;
            categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Proteins", "Carbohydrates", "Fats", "Dairy", "Vegetables", "Fruits", "Grains", "Sugars", "Beverages", "Seafood", "Snacks", "Legumes", "Nuts and Seeds", "Sweets and Desserts", "Baked Goods", "Condiments and Sauces", "Processed Foods", "Herbal and Spices", "Oils", "Alcoholic Beverages", "Non-Alcoholic Beverages" });
            categoryComboBox.Location = new Point(208, 276);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(195, 28);
            categoryComboBox.TabIndex = 19;
            // 
            // bestBeforeDateTimePicker
            // 
            bestBeforeDateTimePicker.Location = new Point(208, 83);
            bestBeforeDateTimePicker.Name = "bestBeforeDateTimePicker";
            bestBeforeDateTimePicker.Size = new Size(265, 27);
            bestBeforeDateTimePicker.TabIndex = 20;
            // 
            // preferenceLabel
            // 
            preferenceLabel.AutoSize = true;
            preferenceLabel.Font = new Font("Microsoft YaHei UI", 9F);
            preferenceLabel.ForeColor = Color.DarkGreen;
            preferenceLabel.Location = new Point(106, 326);
            preferenceLabel.Name = "preferenceLabel";
            preferenceLabel.Size = new Size(92, 20);
            preferenceLabel.TabIndex = 21;
            preferenceLabel.Text = "Preference:";
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Location = new Point(208, 326);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(55, 24);
            yesRadioButton.TabIndex = 22;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(351, 326);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(52, 24);
            noRadioButton.TabIndex = 23;
            noRadioButton.TabStop = true;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            // 
            // ItemUploading
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(531, 441);
            Controls.Add(noRadioButton);
            Controls.Add(yesRadioButton);
            Controls.Add(preferenceLabel);
            Controls.Add(bestBeforeDateTimePicker);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(healthStarRatingComboBox);
            Controls.Add(healthStarRatingLabel);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(expireDateLabel);
            Controls.Add(unitPriceLabel);
            Controls.Add(quanityLabel);
            Controls.Add(itemNameLabel);
            Controls.Add(foodNameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ItemUploading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Uploading";
            FormClosing += ItemUploading_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox foodNameTextBox;
        private Label itemNameLabel;
        private Label quanityLabel;
        private Label unitPriceLabel;
        private Label expireDateLabel;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private Button saveButton;
        private Button cancelButton;
        private Label healthStarRatingLabel;
        private ComboBox healthStarRatingComboBox;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private DateTimePicker bestBeforeDateTimePicker;
        private Label preferenceLabel;
        private RadioButton yesRadioButton;
        private RadioButton noRadioButton;
    }
}