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
            labelResult.Text = "";           
        }

        public static int one = 1;
        public static int two = 2;
        public static int three = 3;
        public static int four = 4;
        public static int five = 5;
        public static int six = 6;
        public static int seven = 7;
        public static int eight = 8;
        public static int nine = 9;
        public static float point = 0;

        public int x;
        public int y;
        public int z;

        public float result;
        public string expression = "";
        public string emptyExpression = "";
        public bool fillValue = false;

        List<int> value1 = new List<int>() { };
        List<int> value2 = new List<int>() { };

        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();

        private void buttonNull_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            labelExpression.Text = emptyExpression;
            labelResult.Text = emptyExpression;
            sb1.Clear();
            sb2.Clear();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            fillValue = false;
            value1.Add(0);
            sb1.Append(new char[] { '0' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(1);
            sb1.Append(new char[] { '1' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(2);
            sb1.Append(new char[] { '2' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(3);
            sb1.Append(new char[] { '3' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(4);
            sb1.Append(new char[] { '4' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(5);
            sb1.Append(new char[] { '5' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(6);
            sb1.Append(new char[] { '6' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(7);
            sb1.Append(new char[] { '7' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(8);
            sb1.Append(new char[] { '8' });
            labelResult.Text = sb1.ToString();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            fillValue = false;

            value1.Add(9);
            sb1.Append(new char[] { '9' });
            labelResult.Text = sb1.ToString();
        }

       

        private void buttonDelete_Click(object sender, EventArgs e)
        {   
            int.Parse(sb1.ToString());
            
            if (fillValue == false)
            {
                sb1.Remove(sb1.Length - 2, sb1.Length - 1);
                value1.Add(sb1.Length);                
                labelResult.Text = sb1.ToString();
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




*/