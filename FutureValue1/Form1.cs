﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /* This program calculates the future value
                         * when a user enters the monthly investment amuont,
                         * the yearly interest rate and the number of years
                         * the investment will be made */

            /* Get the monthly investment amount and the yearly ineterst rate
             * and convert them into decimal */
            decimal monthlyInvestment;
            monthlyInvestment = Decimal.Parse(txtMonthlyInvestment.Text);

            decimal yearlyInterestRate;
            yearlyInterestRate = Decimal.Parse(txtInterestRate.Text);

            // Get the number of years and convert them into months
            int years;
            years = Int32.Parse(txtYears.Text);

            int months;
            months = years * 12;

            /* Calculate the monthly interest rate based on the 
             * yearly interest rate entered by the user */
            decimal monthlyInterestRate;
            monthlyInterestRate = (yearlyInterestRate / 12) / 100;


            /* Set the intial future value to zero, and
             * calcualte the future value using the monthly investment 
             * and the monthly interest rate and display the result */
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit from the program when finished the task
            this.Close();

        }
    }
}
