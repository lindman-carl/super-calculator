using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private string name = "NoName";
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingsCalculator savingsCalc = new SavingsCalculator();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "The Super Calculator by Carl Lindman";

            // Input controls
            rbtnUsUnit.Checked = true;
            rbtnFemale.Checked = true;
            lblHeight.Text = "Height (ft, in)";
            lblWeight.Text = "Weight (lbs)";

            // Output controls
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private bool ReadSavingsInput()
        {
            string failMessage = "";
            bool success = true;

            // Initial deposit
            double initialDeposit = ReadDouble(txtInitialDeposit.Text, out success);
            if (success)
            {
                savingsCalc.InitialDeposit = initialDeposit;
            }
            else
            {
                failMessage += "  Initial deposit\n";
            }

            // Monthly deposit
            double monthlyDeposit = ReadDouble(txtMonthlyDeposit.Text, out success);
            if (success)
            {
                savingsCalc.MonthlyDeposit = monthlyDeposit;
            } 
            else
            {
                failMessage += "  Monthly deposit\n";
            }

            // Period, this could have been an integer instead. But I don't value saving 4 bytes more than writing another function
            double period = ReadDouble(txtPeriod.Text, out success);
            if (success)
            {
                savingsCalc.Period = period;
            }
            else
            {
                failMessage += "  Period\n";
            }

            // Growth rate
            double growthRate = ReadDouble(txtGrowthRate.Text, out success);
            if (success)
            {
                savingsCalc.GrowthRate = growthRate;
            }
            else
            {
                failMessage += "  Growth rate\n";
            }

            // Fees
            double fees = ReadDouble(txtFees.Text, out success);
            if (success)
            {
                savingsCalc.FeeRate = fees;
            }
            else
            {
                failMessage += "  Fees\n";
            }

            // If failMessage is not empty then it means we failed somewhere
            if (!String.IsNullOrEmpty(failMessage))
            {
                // Add message to beginning of failMessage
                failMessage = "Invalid value in:\n\n" + failMessage;

                // Show MessageBox with failMessage
                MessageBox.Show(failMessage, "Error Invalid Input");
                // Fail
                return false;
            }
            else
            {
                // Success
                return true;
            }

        }

        private double ReadDouble(string str,out bool success)
        {
            double value = -1.00;
            success = false;

            if (double.TryParse(str, out value))
            {
                success = true;
            }

            return value;
        }

        private void ReadName()
        {
            txtName.Text.Trim();
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                bmiCalc.Name = txtName.Text;
            } else
            {
                bmiCalc.Name = "Unknown";
            }

            groupBoxResults.Text = $"Results for {bmiCalc.Name}";
        }

        private void ReadHeight()
        {
            // local height variable
            double height = 0;

            // Trim text
            txtHeight.Text.Trim();
            txtHeightFt.Text.Trim();

            // Parse text as double
            if (Double.TryParse(txtHeight.Text, out double result))
            {
                height = result;
            }

            // include feet if american
            if (bmiCalc.Unit == UnitTypes.American)
            {
                // Parse text as double
                if (Double.TryParse(txtHeightFt.Text, out double ftResult))
                {
                    height += ftResult * 12;
                }
            }

            // Will return 0 if input is invalid
            bmiCalc.Height = height;

        }

        private void ReadWeight()
        {
            txtWeight.Text.Trim();
            // Parse text as double
            if (Double.TryParse(txtWeight.Text, out double result))
            {
                bmiCalc.Weight = result;
            }
            else
            {
                bmiCalc.Weight = 0;
            }
        }

        private void ReadUnit()
        {
            // Check which radiobutton is checked and set bmiCalc.Unit
            if (rbtnMetricUnit.Checked)
            {
                bmiCalc.Unit = UnitTypes.Metric;
            } else if (rbtnUsUnit.Checked) {
                bmiCalc.Unit = UnitTypes.American;
            }
        }

        private bool ReadInputBMI()
        {
            ReadName();
            ReadUnit();
            ReadHeight();
            ReadWeight();
            // TODO: Implement input validation
            return true;
        }

        private void DisplayBMI()
        {
            // Calculate bmi
            double bmi = bmiCalc.CalculateBMI();

            // Set label
            lblBMI.Text = $"{bmi,4:F2}";

            // Set bmi category label
            lblWeightCategory.Text = GetWeightCategoryLabel(bmi);

            // Set normal range label
            lblNormalRange.Text = GetNormalRangeLabel();


            // Bugtesting
            Console.WriteLine($"Calc!\nName: {bmiCalc.Name}\nHeight: {bmiCalc.Height}\nWeight: {bmiCalc.Weight}\nBMI: {bmi,4:F2}");
        }

        private string GetWeightCategoryLabel(double bmi)
        {
            string category = "";

            // Why not return in each if statement? Because I used the category variable to concat a longer string and now I'm too lazy to change it
            if (bmi < 18.5)
            {
                // Too low bmi
                category = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                // Good bmi
                category = "Normal";
            }
            else if (bmi < 30)
            {
                // Too high bmi
                category = "Overweight";
            } 
            else
            {
                //:(
                category = "Obese";
            }

            return category;
        }

        private string GetNormalRangeLabel()
        {
            // Gets normal bmi range from bmiCalc in an array
            double[] range = bmiCalc.CalculateNormalBMI();
            string text = "Normal weight should be between "; 

            if (bmiCalc.Unit == UnitTypes.Metric)
                text += $"{range[0]:F2} and {range[1]:F2} kg";
            else
                text += $"{range[0]:F2} and {range[1]:F2} lbs";

            return text;
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
            {
                DisplayBMI();
            }
        }

        private void radioButtonsUnit_CheckChanged(object sender, EventArgs e)
        {
            // Update unit labels based on which radio button is checked and set bmiCalc unittype
            if (rbtnMetricUnit.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";

                // Hides feet textbox
                txtHeightFt.Hide();
            } 
            else if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbs)";

                // Show feet textbox
                txtHeightFt.Show();
            }
        }

        private void DisplaySavings()
        {
            // Calculate savings
            double[] savings = savingsCalc.CalculateSavings();

            // Set labels
            lblAmountPaid.Text = savings[0].ToString("F2");
            lblAmountEarned.Text = savings[1].ToString("F2");
            lblFinalBalance.Text = savings[2].ToString("F2");
            lblTotalFees.Text = savings[3].ToString("F2");
        }

        private void btnCalcSavings_Click(object sender, EventArgs e)
        {
            if (ReadSavingsInput())
            {
                // If successful
                DisplaySavings();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
