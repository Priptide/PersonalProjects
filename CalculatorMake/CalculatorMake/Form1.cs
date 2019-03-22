using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMake
{
    public partial class Form1 : Form
    {
        public static float MainNumber;

        public bool HasCalcOccured = false;

        public Form1()
        {
            InitializeComponent();
            label1.Text = MainNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "1";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "-" + richTextBox1.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MainNumber = 0;
            label1.Text = "";
            textBox1.Text = "";
            richTextBox1.Text = "";
            HasCalcOccured = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (HasCalcOccured)
                {
                    MainNumber = CalculationClass.Addition(MainNumber, richTextBox1.Text, textBox1);
                    richTextBox1.Text = "";
                    label1.Text = MainNumber.ToString();
                }
                else
                {
                    try
                    {
                        MainNumber = (float)Convert.ToDecimal(richTextBox1.Text);
                    }
                    catch (Exception ez)
                    {
                        textBox1.Text = "ERROR" + ez.ToString();
                    }
                    richTextBox1.Text = "";
                    label1.Text = MainNumber.ToString();
                }
                HasCalcOccured = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (HasCalcOccured)
                {
                    MainNumber = CalculationClass.Subtraction(MainNumber, richTextBox1.Text, textBox1);
                    richTextBox1.Text = "";
                    label1.Text = MainNumber.ToString();
                }
                else
                {
                    try
                    {
                        MainNumber = (float)Convert.ToDecimal(richTextBox1.Text);
                    }
                    catch (Exception ez)
                    {
                        textBox1.Text = "ERROR" + ez.ToString();
                    }
                    richTextBox1.Text = "";
                    label1.Text = MainNumber.ToString();
                }
                HasCalcOccured = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (HasCalcOccured)
                {
                    MainNumber = CalculationClass.Multiplication(MainNumber, richTextBox1.Text, textBox1);
                    richTextBox1.Text = "";
                    label1.Text = MainNumber.ToString();
                }
                else
                {
                    try
                    {
                        MainNumber = (float)Convert.ToDecimal(richTextBox1.Text);
                    }
                    catch (Exception ez)
                    {
                        textBox1.Text = "ERROR" + ez.ToString();
                    }
                    richTextBox1.Text = "";
                    label1.Text = MainNumber.ToString();
                }
                HasCalcOccured = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (HasCalcOccured)
                {
                    MainNumber = CalculationClass.Divison(MainNumber, richTextBox1.Text, textBox1);
                    richTextBox1.Text = "";
                    label1.Text = MainNumber.ToString();
                }
                else
                {
                    try
                    {
                        MainNumber = (float)Convert.ToDecimal(richTextBox1.Text);
                    }
                    catch (Exception ez)
                    {
                        textBox1.Text = "ERROR" + ez.ToString();
                    }
                    richTextBox1.Text = "";
                    label1.Text = MainNumber.ToString();
                }
                HasCalcOccured = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (HasCalcOccured == true)
            {
                textBox1.Text = MainNumber.ToString();
                richTextBox1.Text = "";
            }
            else
            {
                textBox1.Text = richTextBox1.Text;
                richTextBox1.Text = "";
            }
            MainNumber = 0;
            HasCalcOccured = false;
            label1.Text = MainNumber.ToString();
        }
    }
}
