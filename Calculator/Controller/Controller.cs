using System;
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

        public static string DivideTwoNumbers(string firstNumber, string secondNumber, TextBox txtBox)
        {
            double firstNum = double.Parse(firstNumber);
            double secondNum = double.Parse(secondNumber);

            if (secondNum == 0)
            {
                throw new Exception("Can not divide by 0.");
            }

            double result = firstNum / secondNum;
            txtBox.Text = result.ToString();
            return result.ToString();
        }

        public static string MultipleTwoNumbers(string firstNumber, string secondNumber, TextBox txtBox)
        {
            double result = double.Parse(firstNumber) * double.Parse(secondNumber);
            txtBox.Text = result.ToString();
            return result.ToString();
        }

        public static string SquareRoot(string number, TextBox txtBox)
        {
            double result = Math.Sqrt(double.Parse(number));
            txtBox.Text = result.ToString();
            return result.ToString();
        }

        public static string PowerNumber(string number, TextBox txtBox)
        {
            double result = Math.Pow(double.Parse(number), 2);
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
