using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private string valueTemp;
        private StringBuilder sb = new StringBuilder();

        private Boolean isNeedToClear = true;

        public Calculator()
        {
            InitializeComponent();
        }


        private void calc(char mathSign)
        {
            if (!String.IsNullOrEmpty(labelExpression.Text))
            {
                if (String.IsNullOrEmpty(valueTemp))
                {
                    sb = new StringBuilder();
                    valueTemp = labelExpression.Text;
                    sb.Append(valueTemp);
                    sb.Append(mathSign);
                    isNeedToClear = true;
                }
                else
                {
                    sb.Append(labelExpression.Text);
                    labelExpression.Text = new DataTable().Compute(sb.ToString(), null).ToString();;
                    valueTemp = labelExpression.Text;
                    sb.Clear();
                    if (!String.IsNullOrEmpty(mathSign.ToString()))
                    {
                        sb.Append(valueTemp);
                        sb.Append(mathSign);
                    }
                    isNeedToClear = true;
                }
            }
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            calc('+');
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            calc('-');
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            calc('*');
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            calc('/');
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            calc('%');
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            calc('\0');
        }


        private void buttonChangeChar_Click(object sender, EventArgs e)
        {
            // string changeChar;
            // if (labelExpression.Text[0] != '-')
            // {
            //     changeChar = "-";
            //     changeChar += labelExpression.Text;
            // }
            // else
            // {
            //     changeChar = "+";
            //     changeChar += labelExpression.Text;
            // }
            //
            // labelExpression.Text = changeChar;
        }


        private void buttonNull_Click(object sender, EventArgs e)
        {
            labelExpression.Text = "";
            valueTemp = "";
            sb.Clear();
            isNeedToClear = false;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "0";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (isNeedToClear)
            {
                labelExpression.Text = "";
                isNeedToClear = false;
            }

            labelExpression.Text += "9";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //сама доделай
            //ладно, сделаю
            labelExpression.Text = labelExpression.Text.Remove(labelExpression.Text.Length - 1);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            labelExpression.Text = "";
            valueTemp = "";
            sb.Clear();
            isNeedToClear = false;
        }
    }
}