﻿using System;
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
        }
       
        public string value1;
        public string value2;
        public char mathSign;

        public string expression = "";
        public string emptyExpression = "";
        public bool fillValue = false;      

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
            string str = "";
            byte i = 0;
            while (i < labelExpression.Text.Length - 1) 
            {
                str += labelExpression.Text[i];
                i++;
            }
            labelExpression.Text = str;
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (fillValue) 
            {
                calculation(); 
            } 

            mathSign = '+';
            value1 = labelExpression.Text;
            labelExpression.Text += "+";
            fillValue = true;
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            if (fillValue)
            {
                calculation();
            } 

            mathSign = '-';
            value1 = labelExpression.Text;
            labelExpression.Text += "-";
            fillValue = true;
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            if (fillValue)
            {
                calculation();
            } 

            mathSign = '*';
            value1 = labelExpression.Text;
            labelExpression.Text += "*";
            fillValue = true;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (fillValue)
            {
                calculation();
            } 

            mathSign = '/';
            value1 = labelExpression.Text;
            labelExpression.Text += "/";
            fillValue = true;
        }
        
        public void calculation()
        {
            int i = value1.Length + 1;
            while (i < labelExpression.Text.Length)
            {
                value2 += labelExpression.Text[i]; // Добавляем в переменную b, все цифры после знака
                i++;
            }

            if (mathSign == '+') 
            {
                labelExpression.Text = Convert.ToString(Convert.ToDouble(value1) 
                    + Convert.ToDouble(value2)); 
            }
            if (mathSign == '-') 
            {
                labelExpression.Text = Convert.ToString(Convert.ToDouble(value1) 
                    - Convert.ToDouble(value2)); 
            }
            if (mathSign == '*') 
            {
                labelExpression.Text = Convert.ToString(Convert.ToDouble(value1) 
                    * Convert.ToDouble(value2)); 
            }
            if (mathSign == '/') 
            {
                labelExpression.Text = Convert.ToString(Convert.ToDouble(value1) 
                    / Convert.ToDouble(value2)); 
            }
                     
            value2 = null;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            {
                calculation();
                fillValue = false;
            }
        }
    }
}

/*
 *  private void buildValue(int sb1, int sb2)
       {
           if (fillValue == true)
           {
               x = sb1; 
               y = sb2;
           }
       }
 * 
 * 
 * foreach (int i in value1)
           {
               labelExpression.Text = Convert.ToString(i);
           }





int.Parse(sb1.ToString());
            
            if (fillValue == false)
            {
                sb1.Remove(sb1.Length - 2, sb1.Length - 1);
                value1.Add(sb1.Length);                
                labelResult.Text = sb1.ToString();
            }

*/