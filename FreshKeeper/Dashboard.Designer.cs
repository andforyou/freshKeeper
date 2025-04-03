namespace FreshKeeper
{
    partial class DashBoard
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
            addItemButton = new Button();
            allItemsButton = new Button();
            shoppingListButton = new Button();
            oneWeekListBox = new ListBox();
            oneWeekLabel = new Label();
            userNameLinkLabel = new LinkLabel();
            groupBox2 = new GroupBox();
            oneDayListBox = new ListBox();
            oneDayLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // addItemButton
            // 
            addItemButton.BackColor = Color.FloralWhite;
            addItemButton.BackgroundImageLayout = ImageLayout.Center;
            addItemButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addItemButton.ForeColor = Color.DarkGreen;
            addItemButton.Location = new Point(82, 428);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(124, 29);
            addItemButton.TabIndex = 0;
            addItemButton.Text = "Add New Item";
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += addItemButton_Click;
            // 
            // allItemsButton
            // 
            allItemsButton.BackColor = Color.FloralWhite;
            allItemsButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allItemsButton.ForeColor = Color.DarkGreen;
            allItemsButton.Location = new Point(430, 17);
            allItemsButton.Name = "allItemsButton";
            allItemsButton.Size = new Size(124, 29);
            allItemsButton.TabIndex = 1;
            allItemsButton.Text = "All Items List";
            allItemsButton.UseVisualStyleBackColor = false;
            allItemsButton.Click += allItemsButton_Click;
            // 
            // shoppingListButton
            // 
            shoppingListButton.BackColor = Color.FloralWhite;
            shoppingListButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shoppingListButton.ForeColor = Color.DarkGreen;
            shoppingListButton.Location = new Point(373, 428);
            shoppingListButton.Name = "shoppingListButton";
            shoppingListButton.Size = new Size(124, 29);
            shoppingListButton.TabIndex = 5;
            shoppingListButton.Text = "Shopping List";
            shoppingListButton.UseVisualStyleBackColor = false;
            shoppingListButton.Click += shoppingListButton_Click;
            // 
            // oneWeekListBox
            // 
            oneWeekListBox.BackColor = Color.NavajoWhite;
            oneWeekListBox.BorderStyle = BorderStyle.None;
            oneWeekListBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oneWeekListBox.ForeColor = Color.Sienna;
            oneWeekListBox.FormattingEnabled = true;
            oneWeekListBox.ItemHeight = 19;
            oneWeekListBox.Location = new Point(6, 34);
            oneWeekListBox.Name = "oneWeekListBox";
            oneWeekListBox.Size = new Size(235, 285);
            oneWeekListBox.TabIndex = 8;
            // 
            // oneWeekLabel
            // 
            oneWeekLabel.AutoSize = true;
            oneWeekLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oneWeekLabel.ForeColor = Color.Chocolate;
            oneWeekLabel.Location = new Point(313, 72);
            oneWeekLabel.Name = "oneWeekLabel";
            oneWeekLabel.Size = new Size(202, 27);
            oneWeekLabel.TabIndex = 11;
            oneWeekLabel.Text = "Expires This Week:";
            // 
            // userNameLinkLabel
            // 
            userNameLinkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userNameLinkLabel.AutoSize = true;
            userNameLinkLabel.LinkColor = Color.DarkOliveGreen;
            userNameLinkLabel.Location = new Point(35, 21);
            userNameLinkLabel.Name = "userNameLinkLabel";
            userNameLinkLabel.Size = new Size(171, 20);
            userNameLinkLabel.TabIndex = 12;
            userNameLinkLabel.TabStop = true;
            userNameLinkLabel.Text = "User Name, Welcome!";
            userNameLinkLabel.LinkClicked += userNameLinkLabel_LinkClicked;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(oneWeekListBox);
            groupBox2.Location = new Point(307, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 327);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // oneDayListBox
            // 
            oneDayListBox.BackColor = Color.MistyRose;
            oneDayListBox.BorderStyle = BorderStyle.None;
            oneDayListBox.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oneDayListBox.ForeColor = Color.Maroon;
            oneDayListBox.FormattingEnabled = true;
            oneDayListBox.Location = new Point(35, 108);
            oneDayListBox.Name = "oneDayListBox";
            oneDayListBox.Size = new Size(227, 280);
            oneDayListBox.TabIndex = 7;
            //oneDayListBox.DoubleClick += oneDayListBox_DoubleClick;
            // 
            // oneDayLabel
            // 
            oneDayLabel.AutoSize = true;
            oneDayLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oneDayLabel.ForeColor = Color.Crimson;
            oneDayLabel.Location = new Point(6, -2);
            oneDayLabel.Name = "oneDayLabel";
            oneDayLabel.Size = new Size(158, 27);
            oneDayLabel.TabIndex = 10;
            oneDayLabel.Text = "Expires Today:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(oneDayLabel);
            groupBox1.Location = new Point(29, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 327);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(590, 480);
            Controls.Add(oneWeekLabel);
            Controls.Add(groupBox2);
            Controls.Add(userNameLinkLabel);
            Controls.Add(oneDayListBox);
            Controls.Add(shoppingListButton);
            Controls.Add(allItemsButton);
            Controls.Add(addItemButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosing += Dashboard_FormClosing;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addItemButton;
        private Button allItemsButton;
        private Button shoppingListButton;
        private ListBox oneWeekListBox;
        private Label oneWeekLabel;
        private LinkLabel userNameLinkLabel;
        private GroupBox groupBox2;
        private ListBox oneDayListBox;
        private Label oneDayLabel;
        private GroupBox groupBox1;
    }
}