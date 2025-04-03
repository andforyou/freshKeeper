using System;
using System.Windows.Forms;

namespace FreshKeeper
{
    public static class InputValidator
    {
        public static bool ValidateItemInput(string itemName, string quantityText, ComboBox frequencyComboBox = null, ComboBox healthStarRatingComboBox = null, ComboBox categoryComboBox = null)
        {
            if (string.IsNullOrWhiteSpace(itemName) || string.IsNullOrWhiteSpace(quantityText))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(quantityText, out _))
            {
                MessageBox.Show("Please enter a valid number for quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            if (frequencyComboBox != null && frequencyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a frequency.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check  health star rating
            if (healthStarRatingComboBox != null && healthStarRatingComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a health star rating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (categoryComboBox != null && categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
