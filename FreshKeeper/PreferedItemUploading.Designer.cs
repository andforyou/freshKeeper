namespace FreshKeeper
{
    partial class PreferedItemUploading
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
            itemNameLabel = new Label();
            quantityLabel = new Label();
            frequencyLabel = new Label();
            itemNameTextBox = new TextBox();
            quantityTextBox = new TextBox();
            frequencyComboBox = new ComboBox();
            addButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(151, 50);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(93, 20);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item Name:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(102, 100);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(142, 20);
            quantityLabel.TabIndex = 1;
            quantityLabel.Text = "Prefered Quantity:";
            // 
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Location = new Point(88, 153);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new Size(156, 20);
            frequencyLabel.TabIndex = 2;
            frequencyLabel.Text = "Prefered Frequency:";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(250, 47);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(179, 27);
            itemNameTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(250, 97);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(179, 27);
            quantityTextBox.TabIndex = 4;
            // 
            // frequencyComboBox
            // 
            frequencyComboBox.FormattingEnabled = true;
            frequencyComboBox.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Occasionally" });
            frequencyComboBox.Location = new Point(250, 150);
            frequencyComboBox.Name = "frequencyComboBox";
            frequencyComboBox.Size = new Size(179, 28);
            frequencyComboBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(250, 234);
            addButton.Name = "addButton";
            addButton.Size = new Size(223, 34);
            addButton.TabIndex = 6;
            addButton.Text = "Add New Prefered Item";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(35, 234);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(169, 34);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // PreferedItemUploading
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 284);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(frequencyComboBox);
            Controls.Add(quantityTextBox);
            Controls.Add(itemNameTextBox);
            Controls.Add(frequencyLabel);
            Controls.Add(quantityLabel);
            Controls.Add(itemNameLabel);
            Name = "PreferedItemUploading";
            Text = "Prefered Item Uploading";
            FormClosing += PreferedItemUploading_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemNameLabel;
        private Label quantityLabel;
        private Label frequencyLabel;
        private TextBox itemNameTextBox;
        private TextBox quantityTextBox;
        private ComboBox frequencyComboBox;
        private Button addButton;
        private Button cancelButton;
    }
}