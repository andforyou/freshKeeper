namespace FreshKeeper
{
    partial class AllItemsList
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
            updateButton = new Button();
            deleteButton = new Button();
            allItemsCheckedListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.Location = new Point(458, 36);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 0;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(458, 88);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // allItemsCheckedListBox
            // 
            allItemsCheckedListBox.FormattingEnabled = true;
            allItemsCheckedListBox.Location = new Point(35, 36);
            allItemsCheckedListBox.Name = "allItemsCheckedListBox";
            allItemsCheckedListBox.Size = new Size(389, 246);
            allItemsCheckedListBox.TabIndex = 3;
            // 
            // AllItemsList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 332);
            Controls.Add(allItemsCheckedListBox);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Name = "AllItemsList";
            Text = "All Items List";
            FormClosing += AllItemsList_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button updateButton;
        private Button deleteButton;
        private CheckedListBox allItemsCheckedListBox;
    }
}