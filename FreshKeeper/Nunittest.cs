using NUnit.Framework;
using System.Windows.Forms;

namespace FreshKeeper.Tests {
    [TestFixture]
    public class InputValidatorTests {
        [Test]
        public void ValidateItemInput_AllFieldsValid_ReturnsTrue() {
            string itemName = "Apple";
            string quantityText = "5";

            ComboBox frequencyComboBox = new ComboBox();
            frequencyComboBox.Items.Add("Daily");
            frequencyComboBox.SelectedIndex = 0;

            ComboBox healthStarRatingComboBox = new ComboBox();
            healthStarRatingComboBox.Items.Add("4");
            healthStarRatingComboBox.SelectedIndex = 0;

            ComboBox categoryComboBox = new ComboBox();
            categoryComboBox.Items.Add("Fruit");
            categoryComboBox.SelectedIndex = 0;

            bool result = InputValidator.ValidateItemInput(itemName, quantityText, frequencyComboBox, healthStarRatingComboBox, categoryComboBox);
            Console.WriteLine(result == true ? "Pass: All fields valid" : "Fail: All fields valid");
        }

        [Test]
        public void ValidateItemInput_EmptyItemName_ReturnsFalse() {
            string itemName = "";
            string quantityText = "5";

            bool result = InputValidator.ValidateItemInput(itemName, quantityText);
            Console.WriteLine(result == false ? "Pass: Empty item name" : "Fail: Empty item name");
        }

        [Test]
        public void ValidateItemInput_NonNumericQuantity_ReturnsFalse() {
            string itemName = "Apple";
            string quantityText = "abc";

            bool result = InputValidator.ValidateItemInput(itemName, quantityText);
            Console.WriteLine(result == false ? "Pass: Non-numeric quantity" : "Fail: Non-numeric quantity");
        }

        [Test]
        public void ValidateItemInput_NoFrequencySelected_ReturnsFalse() {
            string itemName = "Apple";
            string quantityText = "5";

            ComboBox frequencyComboBox = new ComboBox();

            bool result = InputValidator.ValidateItemInput(itemName, quantityText, frequencyComboBox);
            Console.WriteLine(result == false ? "Pass: No frequency selected" : "Fail: No frequency selected");
        }

        [Test]
        public void ValidateItemInput_NoHealthStarRatingSelected_ReturnsFalse() {
            string itemName = "Apple";
            string quantityText = "5";

            ComboBox healthStarRatingComboBox = new ComboBox();

            bool result = InputValidator.ValidateItemInput(itemName, quantityText, null, healthStarRatingComboBox);
            Console.WriteLine(result == false ? "Pass: No health star rating selected" : "Fail: No health star rating selected");
        }

        [Test]
        public void ValidateItemInput_NoCategorySelected_ReturnsFalse() {
            string itemName = "Apple";
            string quantityText = "5";

            ComboBox categoryComboBox = new ComboBox();

            bool result = InputValidator.ValidateItemInput(itemName, quantityText, null, null, categoryComboBox);
            Console.WriteLine(result == false ? "Pass: No category selected" : "Fail: No category selected");
        }
    }
}
