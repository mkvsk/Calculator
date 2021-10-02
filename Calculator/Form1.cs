using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public string value1;
        public string value2;
        public char mathSign;

        public string expression;
        public static string emptyExpression = "";
        public bool fillValue = false;

        public int counter = 0;
        public int tmp;

        public Calculator()
        {
            InitializeComponent();
        }
       
        private void buttonNull_Click(object sender, EventArgs e)
        {
            labelExpression.Text = null;
            fillValue = false;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "0";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "9";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {   
            expression = labelExpression.Text;
            labelExpression.Text = "";
            for (int i = 0; i < expression.Length - 1; i++) 
            {
                labelExpression.Text += expression[i];               
            }          
        }


        private void buttonAddition_Click(object sender, EventArgs e)
        {
           if (fillValue)
            {
                calc();
            }
            counter++;
            mathSign = '+';
            value1 = labelExpression.Text;
            labelExpression.Text += "+";
            fillValue = true;
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            if (fillValue)
            {
                calc();
            }
            counter++;
            mathSign = '-';
            value1 = labelExpression.Text;
            labelExpression.Text += "-";
            fillValue = true;
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            if (fillValue)
            {
                calc();
            }
            counter++;
            mathSign = '*';
            value1 = labelExpression.Text;
            labelExpression.Text += "*";
            fillValue = true;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (fillValue)
            {
                calc();
            }
            counter++;
            mathSign = '/';
            value1 = labelExpression.Text;
            labelExpression.Text += "/";
            fillValue = true;
        }

        public void calc()
        {
            int i = value1.Length + 1;
            while (i < labelExpression.Text.Length)
            {
                value2 += labelExpression.Text[i];
                i++;
            }

            if (mathSign == '+')
            {
                value1 = Convert.ToString(Convert.ToDouble(value1)
                    + Convert.ToDouble(value2));
                labelExpression.Text = value1;
            }
            if (mathSign == '-')
            {
                value1 = Convert.ToString(Convert.ToDouble(value1)
                    - Convert.ToDouble(value2));
                labelExpression.Text = value1;
            }
            if (mathSign == '*')
            {
                value1 = Convert.ToString(Convert.ToDouble(value1)
                    * Convert.ToDouble(value2));
                labelExpression.Text = value1;
            }
            if (mathSign == '/')
            {
                value1 = Convert.ToString(Convert.ToDouble(value1)
                    / Convert.ToDouble(value2));
                labelExpression.Text = value1;
            }
            if (mathSign == '%')
            {
                value1 = Convert.ToString(Convert.ToDouble(value1)
                    / 100 * Convert.ToDouble(value2));
                labelExpression.Text = value1;
            }
                                  
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            calc();
            fillValue = false;
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (fillValue)
            {
                calc();
            }

            mathSign = '%';
            value1 = labelExpression.Text;
            labelExpression.Text += "%";
            fillValue = true;
        }

        private void buttonChangeChar_Click(object sender, EventArgs e)
        {
            string changeChar;
            if (labelExpression.Text[0] != '-')
            {
                changeChar = "-";
                changeChar += labelExpression.Text;                
            }
            else
            {
                changeChar = "+";
                changeChar += labelExpression.Text;
            }
            labelExpression.Text = changeChar;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            labelExpression.Text = "";            
        }
    }
}