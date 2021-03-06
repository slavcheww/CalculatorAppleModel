using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string oldInput;
        private string textInput;
        private bool isButtonClicked;
        private bool isAddButtonClicked;
        private bool isSubstractButtonClicked;
        private bool isDivideButtonClicked;
        private bool isMultiplyButtonClicked;

        public Form1()
        {
            InitializeComponent();
            resultTxtBox.Text = "0";
            ResetInputs();
            isButtonClicked = false;
            isAddButtonClicked = false;
            isSubstractButtonClicked = false;
            isDivideButtonClicked = false;
            isMultiplyButtonClicked = false;
            resultTxtBox.BorderStyle = BorderStyle.None;
            resultTxtBox.ForeColor = Color.White;
            resultTxtBox.TextAlign = HorizontalAlignment.Right;
        }

        private void DoTheCalculation()
        {
            if (isAddButtonClicked)
            {
                textInput = Controller.Controller.AddTwoNumbers(oldInput, textInput, resultTxtBox);
                isAddButtonClicked = false;
            }
            else if (isSubstractButtonClicked)
            {
                textInput = Controller.Controller.SubstractTwoNumbers(oldInput, textInput, resultTxtBox);
                isSubstractButtonClicked = false;
            }
            else if (isDivideButtonClicked)
            {
                isDivideButtonClicked = false;
                try
                {
                    textInput = Controller.Controller.DivideTwoNumbers(oldInput, textInput, resultTxtBox);
                }
                catch (Exception ex)
                {
                    resultTxtBox.Text = ex.Message;
                    ResetInputs();
                }
            }
            else if (isMultiplyButtonClicked)
            {
                textInput = Controller.Controller.MultipleTwoNumbers(oldInput, textInput, resultTxtBox);
                isMultiplyButtonClicked = false;
            }
            
        }

        private void EnableAllButtons()
        {
            Controller.Controller.EnableButton(plusBtn);
            Controller.Controller.EnableButton(substractBtn);
            Controller.Controller.EnableButton(divideBtn);
            Controller.Controller.EnableButton(multipleBtn);
            Controller.Controller.EnableButton(equalsBtn);
            Controller.Controller.EnableButton(squareRootBtn);
        }

        private void DisableAllButtons()
        {
            Controller.Controller.DisableButton(plusBtn);
            Controller.Controller.DisableButton(substractBtn);
            Controller.Controller.DisableButton(divideBtn);
            Controller.Controller.DisableButton(multipleBtn);
            Controller.Controller.DisableButton(equalsBtn);
            Controller.Controller.DisableButton(squareRootBtn);
        }

        private void OnNumberClick()
        {
            textInput = string.Empty;
            Controller.Controller.ClearTextBox(resultTxtBox);
            isButtonClicked = false;
            EnableAllButtons();
        }

        private void OnOperatorButtonClick()
        {
            DoTheCalculation();
            isButtonClicked = true;
            oldInput = textInput;
        }

        private void ResetInputs()
        {
            textInput = "0";
            oldInput = "0";
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (!Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || textInput.Contains("."))
            {
                resultTxtBox.Text += 0;
                textInput += 0;
            }
            if (isButtonClicked)
            {
                textInput = "0";
                Controller.Controller.ResetTextBoxText(resultTxtBox);
                EnableAllButtons();
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }
            resultTxtBox.Text += 1;
            textInput += 1;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }

            resultTxtBox.Text += 2;
            textInput += 2;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }

            resultTxtBox.Text += 3;
            textInput += 3;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }

            resultTxtBox.Text += 4;
            textInput += 4;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }

            resultTxtBox.Text += 5;
            textInput += 5;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }

            resultTxtBox.Text += 6;
            textInput += 6;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }

            resultTxtBox.Text += 7;
            textInput += 7;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }

            resultTxtBox.Text += 8;
            textInput += 8;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.CheckIfResultBoxIsEmpty(textInput) || isButtonClicked)
            {
                OnNumberClick();
            }

            resultTxtBox.Text += 9;
            textInput += 9;
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            ResetInputs();
            Controller.Controller.ResetTextBoxText(resultTxtBox);
            isButtonClicked = false;
            EnableAllButtons();
        }

        private void squareRootBtn_Click(object sender, EventArgs e)
        {
            DoTheCalculation();
            textInput = Controller.Controller.SquareRoot(textInput, resultTxtBox);
        }

        private void powBtn_Click(object sender, EventArgs e)
        {
            DoTheCalculation();
            textInput = Controller.Controller.PowerNumber(textInput, resultTxtBox);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            OnOperatorButtonClick();
            isAddButtonClicked = true;
            DisableAllButtons();
        }

        private void substractBtn_Click(object sender, EventArgs e)
        {
            OnOperatorButtonClick();
            isSubstractButtonClicked = true;
            DisableAllButtons();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            OnOperatorButtonClick();
            isDivideButtonClicked = true;
            DisableAllButtons();
        }

        private void multipleBtn_Click(object sender, EventArgs e)
        {
            OnOperatorButtonClick();
            isMultiplyButtonClicked = true;
            DisableAllButtons();
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            DoTheCalculation();
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            if (!textInput.Contains("."))
            {
                textInput += ".";
                resultTxtBox.Text += ",";
            }
            
        }
    }
}
