using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversion
{
    public partial class Form1 : Form
    {
        double value,number;
        public Form1()
        {
            InitializeComponent();
        }

        private void numberInput_TextChanged(object sender, EventArgs e)
        {
           
            

            try
            {
                number = Convert.ToDouble(numberInput.Text);
              
               

            }
            catch
            {
                outputLabel.Text = "You must enter an integer";
            }

            
        }

       

        private void conversionInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(conversionInput.Text);
            }
            catch
            {
                outputLabel.Text = "You must enter an integer";
            }
            
        }
        public double InchesToCm(double x)
        {
            double centimetres;

            centimetres = Convert.ToDouble(x * 2.54);
            return centimetres;
        }

        public double FeetToCm (double x)
        {
            double centimetres;

            centimetres = Convert.ToDouble(x * 30.48);
            return centimetres;
        }

        public double YardsToMetres (double x)
        {
            double metres;

            metres = Convert.ToDouble(x * 0.91);
            return metres;
        }

        public double MilesToKilometres (double x)
        {
            double kilometres;

            kilometres = Convert.ToDouble(x * 1.6);
            return kilometres;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double result;
            if (number == 1)
            {
                result = InchesToCm(value);
                outputLabel.Text = value + " inches = " + result.ToString("N2") + " centimetres";
            }
            else if (number == 2)
            {
                result = FeetToCm(value);
                outputLabel.Text = value + " feet = " + result.ToString("N2") + " centimetres";

            }
            else if (number == 3)
            {
                result = YardsToMetres(value);
                outputLabel.Text = value + " yards = " + result.ToString("N2") + " metres";

            }
            else if (number == 4)
            {
                result =MilesToKilometres(value); 
                outputLabel.Text = value + " miles = " + result.ToString("N2") + " kilometres";
            }
            else
            {
                outputLabel.Text = "You must enter a number between 1 and 4";
            }
        }
    }

}
