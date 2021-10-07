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
        private BMRCalculator bmrCalc = new BMRCalculator();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "The Super Calculator by Carl Lindman";

            // Init rbuttons
            rbtnUsUnit.Checked = true;
            rbtnFemale.Checked = true;
            rbtnActivitySedentary.Checked = true; // humans are lazy by nature

            // Init unit labels
            lblHeight.Text = "Height (ft, in)";
            lblWeight.Text = "Weight (lbs)";

            // Initialize textboxes to be empty
            // BMI
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;

            // Savings
            txtInitialDeposit.Text = string.Empty;
            txtMonthlyDeposit.Text = string.Empty;
            txtGrowthRate.Text = string.Empty;
            txtPeriod.Text = string.Empty;
            txtFees.Text = string.Empty;

            // BMR
            txtAge.Text = string.Empty;
        }

        private bool ReadSavingsInput()
        {
            string failMessage = "";
            bool success;

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
                MessageBox.Show(failMessage, "Error (Savings) Invalid Input");
                // Fail
                return false;
            }
            else
            {
                // Success
                return true;
            }

        }

        private bool ReadBMRInput()
        {
            string failMessage = "";
            bool success;

            // Weight
            double weight = ReadDouble(txtWeight.Text, out success);
            if (success)
            {
                bmrCalc.Weight = weight;
            }
            else
            {
                failMessage += "  Weight\n";
            }

            // Height
            double height = ReadDouble(txtHeight.Text, out success);
            if (success)
            {
                bmrCalc.Height = height;
            }
            else
            {
                failMessage += "  Height\n";
            }

            // Age
            int age = ReadInt(txtAge.Text, out success);
            if (success)
            {
                bmrCalc.Age = age;
            }
            else
            {
                failMessage += "  Age\n";
            }

            // Gender
            if (rbtnFemale.Checked)
            {
                bmrCalc.Female = true;
            }
            else
            {
                // If female is not checked then we must be a male (this could be somewhat controversial depending on who you ask)
                bmrCalc.Female = false;
            }

            // Activity level
            bmrCalc.ActivityLevel = ReadActivityLevel();

            // If failMessage is not empty then it means we failed somewhere
            if (!String.IsNullOrEmpty(failMessage))
            {
                // Add message to beginning of failMessage
                failMessage = "Invalid value in:\n\n" + failMessage;

                // Show MessageBox with failMessage
                MessageBox.Show(failMessage, "Error (BMR) Invalid Input");
                // Fail
                return false;
            }
            else
            {
                // Success
                return true;
            }
        }
        private int ReadActivityLevel()
        {
            int level = -1;
            // Extensive use of if else statements are not recommended for people with weak hearts. Actually, probaly not for anyone
            if (rbtnActivitySedentary.Checked)
            {
                level = 0;
            } 
            else if (rbtnActivityLight.Checked)
            {
                level = 1;
            }
            else if (rbtnActivityModerate.Checked) 
            {
                level = 2;
            }
            else if (rbtnActivityVery.Checked)
            {
                level = 3;
            } 
            else if (rbtnActivityExtra.Checked)
            {
                level = 4;
            }

            return level;
        }

        private double ReadDouble(string str, out bool success)
        {
            double value = -1.00;
            success = false;

            if (double.TryParse(str, out value))
            {
                success = true;
            }

            return value;
        }

        private int ReadInt(string str, out bool success)
        {
            int value = -1;
            success = false;

            if (int.TryParse(str, out value))
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

                // Sets unit in calculators
                bmiCalc.Unit = UnitTypes.Metric;
                bmrCalc.Unit = UnitTypes.Metric;

                // Hides feet textbox
                txtHeightFt.Hide();
            } 
            else if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbs)";

                // Sets unit in calculators
                bmiCalc.Unit = UnitTypes.American;
                bmrCalc.Unit = UnitTypes.American;

                // Show feet textbox
                txtHeightFt.Show();
            }

            // Clear input fields
            txtHeight.Text = string.Empty;
            txtHeightFt.Text = string.Empty;
            txtWeight.Text = string.Empty;

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

        private void DisplayBMR()
        {
            double[] values = bmrCalc.GetValues();
            double bmr = values[0];
            double maintainWeight = values[1];

            listBoxBMR.Items.Clear();
            listBoxBMR.Items.Add($"BMR RESULTS FOR {name}\n");
            listBoxBMR.Items.Add("");
            listBoxBMR.Items.Add($"Your BMR (calories/day) {bmr}");
            listBoxBMR.Items.Add($"Calories to maintain your weight {maintainWeight}");
            listBoxBMR.Items.Add($"Calories to lose 0,5 kg per week {maintainWeight - 500}");
            listBoxBMR.Items.Add($"Calories to lose 1 kg per week {maintainWeight - 1000}");
            listBoxBMR.Items.Add($"Calories to gain 0,5 kg per week {maintainWeight + 500}");
            listBoxBMR.Items.Add($"Calories to gain 1 kg per week {maintainWeight + 1000}");
            listBoxBMR.Items.Add("");
            listBoxBMR.Items.Add("Losing more than 1000 calories per day is to be avoided"); // i guess you mean losing more than 1 kg, but oh well
        }
        private void btnCalcBMR_Click(object sender, EventArgs e)
        {
            if (ReadBMRInput())
            {
                // If successful
                DisplayBMR();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
