namespace FreshKeeper
{
    partial class ListUpdating
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
            listUpdatingBox = new ListBox();
            addTextBox = new TextBox();
            deleteTextBox = new TextBox();
            addButton = new Button();
            deleteButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listUpdatingBox
            // 
            listUpdatingBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listUpdatingBox.ForeColor = Color.DarkGreen;
            listUpdatingBox.FormattingEnabled = true;
            listUpdatingBox.ItemHeight = 19;
            listUpdatingBox.Location = new Point(12, 12);
            listUpdatingBox.Name = "listUpdatingBox";
            listUpdatingBox.Size = new Size(248, 289);
            listUpdatingBox.TabIndex = 0;
            // 
            // addTextBox
            // 
            addTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTextBox.ForeColor = Color.DarkGreen;
            addTextBox.Location = new Point(290, 44);
            addTextBox.Name = "addTextBox";
            addTextBox.Size = new Size(125, 27);
            addTextBox.TabIndex = 1;
            // 
            // deleteTextBox
            // 
            deleteTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteTextBox.ForeColor = Color.DarkGreen;
            deleteTextBox.Location = new Point(290, 109);
            deleteTextBox.Name = "deleteTextBox";
            deleteTextBox.Size = new Size(125, 27);
            deleteTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LimeGreen;
            addButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.FloralWhite;
            addButton.Location = new Point(441, 42);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FloralWhite;
            deleteButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.DarkGreen;
            deleteButton.Location = new Point(441, 109);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FloralWhite;
            button1.Location = new Point(441, 263);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ListUpdating
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(556, 338);
            Controls.Add(button1);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(deleteTextBox);
            Controls.Add(addTextBox);
            Controls.Add(listUpdatingBox);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ListUpdating";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Updating";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUpdatingBox;
        private TextBox addTextBox;
        private TextBox deleteTextBox;
        private Button addButton;
        private Button deleteButton;
        private Button button1;
    }
}