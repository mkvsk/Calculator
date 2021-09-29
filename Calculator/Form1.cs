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
        public Calculator()
        {
            InitializeComponent();

            labelExpression.Text = "";

            if (tmp == 1)
            {
                value1 = result;
                value2 = null;
                result = null;
            }
            
        }
       
        public string value1;
        public string value2;
        public string result;
        public char mathSign;

        public string expression = "";
        public bool fillValue = false;

        public int step = 0;
        public int tmp = 0;

        private void buttonNull_Click(object sender, EventArgs e)
        {
            labelExpression.Text = null;
            fillValue = false;
            step = 0;
            

            if(mathSign == '+' || mathSign == '-' || mathSign == '*' || mathSign == '/')
            {
                value1 = labelExpression.Text;
                labelExpression.Text = "";
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "0";
            step = 1;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "1";
            step = 1;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "2";
            step = 1;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "3";
            step = 1;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "4";
            step = 1;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "5";
            step = 1;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "6";
            step = 1;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "7";
            step = 1;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "8";
            step = 1;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            fillValue = false;
            labelExpression.Text += "9";
            step = 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string str = "";
            byte i = 0;
            while (i < labelExpression.Text.Length - 1) 
            {
                str += labelExpression.Text[i];
                i++;
            }
            labelExpression.Text = str;
            step = 1;
            //result = null;
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            step = 2;
            mathSign = '+';           
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            step = 2;
            mathSign = '-';   
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            step = 2;
            mathSign = '*';            
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            step = 2;
            mathSign = '/';            
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
                result = Convert.ToString(Convert.ToDouble(value1)
                    + Convert.ToDouble(value2));
                labelExpression.Text = result;
            }
            if (mathSign == '-')
            {
                result = Convert.ToString(Convert.ToDouble(value1)
                    - Convert.ToDouble(value2));
                labelExpression.Text = result;
            }
            if (mathSign == '*')
            {
                result = Convert.ToString(Convert.ToDouble(value1)
                    * Convert.ToDouble(value2));
                labelExpression.Text = result;
            }
            if (mathSign == '/')
            {
                result = Convert.ToString(Convert.ToDouble(value1)
                    / Convert.ToDouble(value2));
                labelExpression.Text = result;
            }
            if (mathSign == '%')
            {
                result = Convert.ToString(Convert.ToDouble(value1)
                    / 100 * Convert.ToDouble(value2));
                labelExpression.Text = result;
            }
             
            value1 = result;                                  
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

            if (step == 3 && value2.Length != 0)
            {
                calc();
            }   
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            mathSign = '%';
            value1 = labelExpression.Text;            
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
    }
}