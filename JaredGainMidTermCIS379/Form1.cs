using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Jared Gain
 * CIS 379
 * 4/7/17
 * This program displays a POS for a medical visit.
 */
namespace JaredGainMidTermCIS379
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare and initialize local variables
            double officeVisitAmount = 0.00;
            double medicationAmount = 0.00;
            double officeVisitMedicationSum = 0.00;
            double DISCOUNT = .10;
            double totalAmount = 0.00;
            double theDiscount = 0.00;

            // Call the validation checks method to validate user input
            if (ValidationCheck(ref officeVisitAmount, ref medicationAmount))
            {
                // Call the charges method to return the sum of office visit and med
                officeVisitMedicationSum = Charges(ref officeVisitAmount, ref medicationAmount);

                // Use an if clause to determine if the user gets a discount
                if (employeeStudentDiscountRadioButton.Checked)
                {
                    // Call the calculate discount method if it applies
                    theDiscount = CalcDiscount(ref DISCOUNT, ref officeVisitAmount, ref medicationAmount);
                    totalAmount = officeVisitAmount + medicationAmount - theDiscount;
                }
                else
                {
                    // No discount
                    totalAmount = officeVisitAmount + medicationAmount;
                }

                // Display method
                Display(aDiscount: theDiscount, theOfficeVisitMedicationSum: officeVisitMedicationSum, theTotalAmount: totalAmount, iOfficeVisitAmount: officeVisitAmount, iMedicationAmount: medicationAmount);
            }
            
        }

        // Bool Validation Check method
        private bool ValidationCheck(ref double theOfficeVisitAmount, ref double theMedicationAmount)
        {
            // Set/Flag variable to indicate whether the input is good or bad
            bool inputGood = false;

            // Use tryparse method for input validation for parts textbox
            if (double.TryParse(officeVisitTextBox.Text, out theOfficeVisitAmount))
            {
                // Use tryparse method for input validation for hours worked
                if (double.TryParse(medicationsTextBox.Text, out theMedicationAmount))
                {
                    // Set flag variable to true
                    inputGood = true;
                }
                else
                {
                    // Display an error message
                    MessageBox.Show("Medication must be a double data type. Please re-enter valid data.");
                    medicationsTextBox.Text = "";
                    medicationsTextBox.Focus();
                }
            }
            else
            {
                // Display an error message
                MessageBox.Show("Office Visit must be a double data type. Please re-enter valid data.");
                officeVisitTextBox.Text = "";
                officeVisitTextBox.Focus();
            }

            // Return a bool data type
            return inputGood;
        }

        // Charges for office visit and medication method
        private double Charges(ref double aOfficeVisitAmount, ref double aMedicationAmount)
        {
            // Declare local variables
            double aSum = 0.00;

            // Add office visit and mediation amount
            aSum = aOfficeVisitAmount + aMedicationAmount;

            // Return the value of sum
            return aSum;
        }

        // Calculate discount for user
        private double CalcDiscount(ref double DISCOUNT, ref double andOfficeVisitAmount, ref double andMedicationAmount)
        {
            // Declare local variables
            double theDiscount = 0.00;

            // apply discount
            theDiscount = (andOfficeVisitAmount + andMedicationAmount) * DISCOUNT;

            return theDiscount;
        }

        // Display method
        private void Display(double aDiscount, double theOfficeVisitMedicationSum, double theTotalAmount, double iOfficeVisitAmount, double iMedicationAmount)
        {
            // Declare local variable
            string output = "Taylor Health and Wellness" +
                            "\n\nSubtota: " + theOfficeVisitMedicationSum.ToString("c2") +
                            "\nDiscount: " + aDiscount.ToString("c2") +
                            "\n\nTotal: " + theTotalAmount.ToString("c2");

            outputLabel.Text = output;
        }
    }
}
