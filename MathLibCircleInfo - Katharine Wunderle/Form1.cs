using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathLibCircleInfo___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 03/06/2021
    //Goal: Calculate diameter, circumference, and area of a circle, given a radius.
    public partial class circleInfo : Form
    {
        public circleInfo()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //Declare variables
            //Input variable
            double radius;
            //Output variables
            double diameter;
            double circ;
            double area;
            //Boolean varaible
            bool tryParseResultBool;

            //INPUT
            //Gather input and verify numeric data
            tryParseResultBool = double.TryParse(radiusInput.Text, out radius);
            if (tryParseResultBool == false || radius <= 0)
            { MessageBox.Show("Error: Please enter a positive numeric value");
                return;
            }

            //CALCULATIONS
            //Calculate diameter
            diameter = 2 * radius;
            //Calculate circumference
            circ = Math.PI * diameter;
            //Calculate area
            area = Math.PI * Math.Pow(radius, 2);

            //OUTPUT
            //Display diameter
            diameterOutput.Text = diameter.ToString("n2");
            //Display circumference
            circOutput.Text = circ.ToString("n2");
            //Display area
            areaOutput.Text = area.ToString("n2");

        }
    }
}
