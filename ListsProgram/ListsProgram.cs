/*
Created by Matthew Ho
Created on 11-16-15
Created for ICS3U
Assignment #5-04
This program uses a list to calculate the average of a set of numbers.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsProgram
{
    public partial class frmListsProgram : Form
    {
        //Global
        double numberOfmarks = 0;
        double totalValue = 0;
        double number = 0;
        double average = 0;

        List<double> listOfNumbers = new List<double>();

        public double Averaging(double total, double numberOfNumbers)
        {//This averages numbers.
            double average = 0;

            average = total / numberOfNumbers;

            return average;
        }

        public frmListsProgram()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(this.nudNumberToAdd.Value);

            listOfNumbers.Add(number);

            this.lstBox.Items.Add(number);

            totalValue = listOfNumbers.Sum();

            numberOfmarks = numberOfmarks + 1;

            average = Averaging(totalValue, numberOfmarks);

            this.lblAverage.Text = "The Average is: " + average;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listOfNumbers.Clear();

            this.lstBox.Items.Clear();

            this.lblAverage.Text = "The Average is: ";
        }
    }
}
