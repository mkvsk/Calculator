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

        public int v1;
        public int v2;  
                

        public bool firstValueIsFilled = false;
        public bool secondValueIsFilled = false;

        public string expression;

        public Calculator()
        {
            InitializeComponent();
        }
       
        private void buttonNull_Click(object sender, EventArgs e)
        {
            labelExpression.Text = null;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "0";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            labelExpression.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
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

        private void getValuesFromText()
        {   
                if (firstValueIsFilled == false)
                {
                    value1 += labelExpression.Text;
                    firstValueIsFilled = true;  
                    labelExpression.Text = "";
                }
                if (secondValueIsFilled == false)
                {   
                    value2 += labelExpression.Text;
                    secondValueIsFilled = true;
                    labelExpression.Text = "";
                }                                     
        }

        private void doNothing() { }

        private void buttonAddition_Click(object sender, EventArgs e)
        {            
            getValuesFromText(); 
            mathSign = '+';
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            mathSign = '-';
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        { 
            mathSign = '*';
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            mathSign = '/';            
        }

        private void calc()
        {   
            string str  = value1 + mathSign + value2;
            if (firstValueIsFilled == true && secondValueIsFilled == true)
            {   
                String result = new DataTable().Compute(str, null).ToString();

               //v1 = Convert.ToDouble(value1);
               //v2 = Convert.ToDouble(value2);  
                
                //v1 = double.Parse(value1);
                //v2 = double.Parse(value2);
                //
                //v1 = Convert.ToInt32(value1);

                if (mathSign == '+')
                {
                    v1 += v2;

                
                //labelExpression.Text = value1;
                }
                if(mathSign == '-')
                {
                    //value1 -= value2;
                }
                if(mathSign == '*')
                {
                    //value1 *= value2;
                }
                if(mathSign == '/')
                {
                    //value1 /= value2;   
                }
                if(mathSign == '%')
                {
                    //value1 = value1 / 100 * value2;
                }
                secondValueIsFilled = false;

                labelExpression.Text = result;
                //labelExpression.Text = Convert.ToString(v1);
                //value1 = Convert.ToString(v1);
                //value2 = "";
                
            }
            else
            {
                doNothing();    
            }              
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {   
            calc();
            labelExpression.Text = value1;
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            mathSign = '%';            
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