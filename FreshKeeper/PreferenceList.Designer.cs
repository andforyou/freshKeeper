namespace FreshKeeper
{
    partial class PreferenceList
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
            preferenceCheckedListBox = new CheckedListBox();
            deleteButton = new Button();
            addNewButton = new Button();
            SuspendLayout();
            // 
            // preferenceCheckedListBox
            // 
            preferenceCheckedListBox.FormattingEnabled = true;
            preferenceCheckedListBox.Location = new Point(36, 41);
            preferenceCheckedListBox.Name = "preferenceCheckedListBox";
            preferenceCheckedListBox.Size = new Size(463, 356);
            preferenceCheckedListBox.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(534, 41);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(113, 29);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addNewButton
            // 
            addNewButton.Location = new Point(534, 85);
            addNewButton.Name = "addNewButton";
            addNewButton.Size = new Size(113, 29);
            addNewButton.TabIndex = 2;
            addNewButton.Text = "Add New";
            addNewButton.UseVisualStyleBackColor = true;
            addNewButton.Click += addNewButton_Click;
            // 
            // PreferenceList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 433);
            Controls.Add(addNewButton);
            Controls.Add(deleteButton);
            Controls.Add(preferenceCheckedListBox);
            Name = "PreferenceList";
            Text = "Preference List";
            FormClosing += PreferenceList_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox preferenceCheckedListBox;
        private Button deleteButton;
        private Button addNewButton;
    }
}