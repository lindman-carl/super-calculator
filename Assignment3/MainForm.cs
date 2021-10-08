using System;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private string name = "NoName";

        // Calculators
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

        // BMI Calculator
        private bool ReadInputBMI()
        {
            string failMessage = "";
            bool success;

            // Name
            ReadName();

            // Weight
            double weight = ReadDouble(txtWeight.Text, out success);
            if (success)
            {
                bmiCalc.Weight = weight;
            }
            else
            {
                failMessage += "  Weight\n";
            }

            // Height
            // if ReadHeight returns -1.00 then we know it failed and we append the fail string to the failMessage
            double height = ReadHeight();
            if (height != -1.00)
            {
                bmiCalc.Height = height;
            }
            else
            {
                failMessage += "  Height";
            }

            // Evaluate if we failed the input
            return EvaluateInput(failMessage, "BMI");

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
            Console.WriteLine($"Calc!\nName: {name}\nHeight: {bmiCalc.Height}\nWeight: {bmiCalc.Weight}\nBMI: {bmi,4:F2}");
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

        // Savings Calculator
        private bool ReadInputSavings()
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

            // Evaluate if we failed the input
            return EvaluateInput(failMessage, "Savings");
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
            if (ReadInputSavings())
            {
                // If successful
                DisplaySavings();
            }
        }

        // BMR Calculator
        private bool ReadInputBMR()
        {
            string failMessage = "";
            bool success;

            // Name
            ReadName();

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
            // if ReadHeight returns -1.00 then we know it failed and we append the fail string to the failMessage
            double height = ReadHeight();
            if (height != -1.00)
            {
                bmrCalc.Height = height;
            }
            else
            {
                failMessage += "  Height";
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

            // Evaluate if we failed the input
            return EvaluateInput(failMessage, "BMR");
        }
        private void DisplayBMR()
        {
            double[] values = bmrCalc.GetValues();
            double bmr = values[0];
            double maintainWeight = values[1];

            listBoxBMR.Items.Clear();
            listBoxBMR.Items.Add($"BMR RESULTS FOR {name}\n");
            listBoxBMR.Items.Add("");
            listBoxBMR.Items.Add($"Your BMR (calories/day)            {bmr:F0}");
            listBoxBMR.Items.Add($"Calories to maintain your weight   {maintainWeight:F0}");
            listBoxBMR.Items.Add($"Calories to lose 0,5 kg per week   {maintainWeight - 500:F0}");
            listBoxBMR.Items.Add($"Calories to lose 1 kg per week     {maintainWeight - 1000:F0}");
            listBoxBMR.Items.Add($"Calories to gain 0,5 kg per week   {maintainWeight + 500:F0}");
            listBoxBMR.Items.Add($"Calories to gain 1 kg per week     {maintainWeight + 1000:F0}");
            listBoxBMR.Items.Add("Losing more than 1000 calories/day is to be avoided"); // how you can lose calories i don't get, but oh well
        }
        private void btnCalcBMR_Click(object sender, EventArgs e)
        {
            if (ReadInputBMR())
            {
                // If successful
                DisplayBMR();
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

        // Functions for parsing integers and doubles
        private double ReadDouble(string str, out bool success)
        {
            double value = -1.00;
            success = false;

            if (double.TryParse(str.Trim(), out value))
            {
                success = true;
            }

            return value;
        }
        private int ReadInt(string str, out bool success)
        {
            int value = -1;
            success = false;

            if (int.TryParse(str.Trim(), out value))
            {
                success = true;
            }

            return value;
        }

        // Generic input readers
        private void ReadName()
        {
            txtName.Text.Trim();
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                name = txtName.Text;
            } 
            else
            {
                name = "NoName";
            }

            groupBoxResults.Text = $"Results for {name}";
        }
        private double ReadHeight()
        {
            bool success, successFt;

            // Height
            double height = ReadDouble(txtHeight.Text, out success);
            double heightFt = ReadDouble(txtHeightFt.Text, out successFt);
            if (success)
            {
                // If feet has also been input then we have to check that aswell, this could also be checked by unittype but that would be over-engineering
                if (successFt)
                {
                    return height + (heightFt * 12);
                }
                else
                {
                    return height;
                }
            }
            else if (successFt)
            {
                return heightFt * 12;
            }
            else
            {
                return -1.00;
            }
        }

        // Function for evaluating input
        private bool EvaluateInput(string failMessage, string calculatorName)
        {
            // I use this in all calculators so I made it a seperate function

            // If failMessage is not empty then it means we failed somewhere
            if (!String.IsNullOrEmpty(failMessage))
            {
                // Add message to beginning of failMessage
                failMessage = "Invalid value in:\n\n" + failMessage;

                // Show MessageBox with failMessage
                MessageBox.Show(failMessage, $"Error in {calculatorName} Invalid Input");
                // Fail
                return false;
            }
            else
            {
                // Success
                return true;
            }
        }

        // Eventhandler for changing unit
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
    }
}
