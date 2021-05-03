using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Controller
{
    public static class Controller
    {
        public static bool CheckIfResultBoxIsEmpty(string textInput)
        {
            if (textInput == "0")
            {
                return true;
            }
            return false;
        }
        
        public static void ClearTextBox(TextBox txtBox)
        {
            txtBox.Text = string.Empty;
        }

        public static void ResetTextBoxText(TextBox txtBox)
        {
            txtBox.Text = "0";
        }

        public static string AddTwoNumbers(string firstNumber, string secondNumber, TextBox txtBox)
        {
            double result = double.Parse(firstNumber) + double.Parse(secondNumber);
            txtBox.Text = result.ToString();
            return result.ToString();
        }

        public static string SubstractTwoNumbers(string firstNumber, string secondNumber, TextBox txtBox)
        {
            double result = double.Parse(firstNumber) - double.Parse(secondNumber);
            txtBox.Text = result.ToString();
            return result.ToString();
        }

        public static void EnableButton(Button button)
        {
            button.Enabled = true;
        }

        public static void DisableButton(Button button)
        {
            button.Enabled = false; ;
        }
    }
}
