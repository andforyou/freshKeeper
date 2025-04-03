namespace FreshKeeper
{
    partial class ShoppingList
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
            shoppingListCheckedListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.LimeGreen;
            backButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.FloralWhite;
            backButton.Location = new Point(434, 295);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 3;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // shoppingListCheckedListBox
            // 
            shoppingListCheckedListBox.FormattingEnabled = true;
            shoppingListCheckedListBox.Location = new Point(12, 12);
            shoppingListCheckedListBox.Name = "shoppingListCheckedListBox";
            shoppingListCheckedListBox.Size = new Size(392, 312);
            shoppingListCheckedListBox.TabIndex = 5;
            // 
            // ShoppingList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(556, 338);
            Controls.Add(shoppingListCheckedListBox);
            Controls.Add(backButton);
            FormClosing += ShoppingList_FormClosing;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ShoppingList";
            Text = "Shopping List";
            ResumeLayout(false);
        }

        #endregion
        private Button backButton;
        private CheckedListBox shoppingListCheckedListBox;
    }
}