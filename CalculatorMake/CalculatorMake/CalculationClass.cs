using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMake
{
    class CalculationClass
    {
        public static float Addition(float OldValue, string newValue, TextBox outputLabel)
        {
            var newValueAdd = new decimal();

            try 
            {
                newValueAdd = Convert.ToDecimal(newValue);
                float x = (float)newValueAdd;
                return (OldValue + x);

            }
            catch(Exception e)
            {
               outputLabel.Text = "ERROR: " + e.ToString();
               return OldValue;
            }
        }

        public static float Subtraction(float OldValue, string newValue, TextBox outputLabel)
        {
            var newValueAdd = new decimal();

            try
            {
                newValueAdd = Convert.ToDecimal(newValue);
                float x = (float)newValueAdd;
                return (OldValue - x);

            }
            catch (Exception e)
            {
                outputLabel.Text = "ERROR: " + e.ToString();
                return OldValue;
            }
        }

        public static float Multiplication(float OldValue, string newValue, TextBox outputLabel)
        {
            var newValueAdd = new decimal();

            try
            {
                newValueAdd = Convert.ToDecimal(newValue);
                float x = (float)newValueAdd;
                return (OldValue * x);

            }
            catch (Exception e)
            {
                outputLabel.Text = "ERROR: " + e.ToString();
                return OldValue;
            }
        }

        public static float Divison(float OldValue, string newValue, TextBox outputLabel)
        {
            var newValueAdd = new decimal();

            try
            {
                newValueAdd = Convert.ToDecimal(newValue);
                float x = (float)newValueAdd;
                return (OldValue / x);

            }
            catch (Exception e)
            {
                outputLabel.Text = "ERROR: " + e.ToString();
                return OldValue;
            }
        }


    }
}
