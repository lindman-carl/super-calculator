
using System;

namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.groupBoxUnit = new System.Windows.Forms.GroupBox();
            this.rbtnUsUnit = new System.Windows.Forms.RadioButton();
            this.rbtnMetricUnit = new System.Windows.Forms.RadioButton();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblNormalRange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblWeightCategoryTitle = new System.Windows.Forms.Label();
            this.lblYourBMI = new System.Windows.Forms.Label();
            this.groupBoxBMI = new System.Windows.Forms.GroupBox();
            this.txtHeightFt = new System.Windows.Forms.TextBox();
            this.groupBoxSaving = new System.Windows.Forms.GroupBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtGrowthRate = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblGrowth = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblMonthlyDeposit = new System.Windows.Forms.Label();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.btnCalcSavings = new System.Windows.Forms.Button();
            this.groupBoxFutureValue = new System.Windows.Forms.GroupBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.lblAmountEarned = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBMR = new System.Windows.Forms.GroupBox();
            this.listBoxBMR = new System.Windows.Forms.ListBox();
            this.btnCalcBMR = new System.Windows.Forms.Button();
            this.groupBoxActivityLevel = new System.Windows.Forms.GroupBox();
            this.rbtnActivityExtra = new System.Windows.Forms.RadioButton();
            this.rbtnActivityVery = new System.Windows.Forms.RadioButton();
            this.rbtnActivityModerate = new System.Windows.Forms.RadioButton();
            this.rbtnActivityLight = new System.Windows.Forms.RadioButton();
            this.rbtnActivitySedentary = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxUnit.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.groupBoxBMI.SuspendLayout();
            this.groupBoxSaving.SuspendLayout();
            this.groupBoxFutureValue.SuspendLayout();
            this.groupBoxBMR.SuspendLayout();
            this.groupBoxActivityLevel.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Your Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AccessibleName = "";
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(6, 49);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(61, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (cm)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 76);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(62, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(224, 46);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(65, 20);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(224, 73);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(65, 20);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxUnit
            // 
            this.groupBoxUnit.Controls.Add(this.rbtnUsUnit);
            this.groupBoxUnit.Controls.Add(this.rbtnMetricUnit);
            this.groupBoxUnit.Location = new System.Drawing.Point(313, 12);
            this.groupBoxUnit.Name = "groupBoxUnit";
            this.groupBoxUnit.Size = new System.Drawing.Size(150, 74);
            this.groupBoxUnit.TabIndex = 7;
            this.groupBoxUnit.TabStop = false;
            this.groupBoxUnit.Text = "Unit";
            // 
            // rbtnUsUnit
            // 
            this.rbtnUsUnit.AutoSize = true;
            this.rbtnUsUnit.Location = new System.Drawing.Point(6, 42);
            this.rbtnUsUnit.Name = "rbtnUsUnit";
            this.rbtnUsUnit.Size = new System.Drawing.Size(108, 17);
            this.rbtnUsUnit.TabIndex = 1;
            this.rbtnUsUnit.TabStop = true;
            this.rbtnUsUnit.Text = "US Unit (foot, lbs)";
            this.rbtnUsUnit.UseVisualStyleBackColor = true;
            this.rbtnUsUnit.CheckedChanged += new System.EventHandler(this.radioButtonsUnit_CheckChanged);
            // 
            // rbtnMetricUnit
            // 
            this.rbtnMetricUnit.AutoSize = true;
            this.rbtnMetricUnit.Location = new System.Drawing.Point(6, 19);
            this.rbtnMetricUnit.Name = "rbtnMetricUnit";
            this.rbtnMetricUnit.Size = new System.Drawing.Size(117, 17);
            this.rbtnMetricUnit.TabIndex = 0;
            this.rbtnMetricUnit.TabStop = true;
            this.rbtnMetricUnit.Text = "Metric Unit (kg, cm)";
            this.rbtnMetricUnit.UseVisualStyleBackColor = true;
            this.rbtnMetricUnit.CheckedChanged += new System.EventHandler(this.radioButtonsUnit_CheckChanged);
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Location = new System.Drawing.Point(95, 118);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(212, 23);
            this.btnCalculateBMI.TabIndex = 8;
            this.btnCalculateBMI.Text = "Calculate BMI";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.lblWeightCategory);
            this.groupBoxResults.Controls.Add(this.lblNormalRange);
            this.groupBoxResults.Controls.Add(this.label3);
            this.groupBoxResults.Controls.Add(this.lblBMI);
            this.groupBoxResults.Controls.Add(this.lblWeightCategoryTitle);
            this.groupBoxResults.Controls.Add(this.lblYourBMI);
            this.groupBoxResults.Location = new System.Drawing.Point(12, 147);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(451, 195);
            this.groupBoxResults.TabIndex = 8;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.AutoSize = true;
            this.lblWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCategory.Location = new System.Drawing.Point(130, 62);
            this.lblWeightCategory.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(200, 15);
            this.lblWeightCategory.TabIndex = 5;
            this.lblWeightCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNormalRange
            // 
            this.lblNormalRange.AutoSize = true;
            this.lblNormalRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNormalRange.Location = new System.Drawing.Point(80, 136);
            this.lblNormalRange.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblNormalRange.Name = "lblNormalRange";
            this.lblNormalRange.Size = new System.Drawing.Size(300, 16);
            this.lblNormalRange.TabIndex = 4;
            this.lblNormalRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(80, 109);
            this.label3.MaximumSize = new System.Drawing.Size(300, 0);
            this.label3.MinimumSize = new System.Drawing.Size(300, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Normal BMI is between 18.50 and 24.9";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Location = new System.Drawing.Point(130, 31);
            this.lblBMI.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(200, 15);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeightCategoryTitle
            // 
            this.lblWeightCategoryTitle.AutoSize = true;
            this.lblWeightCategoryTitle.Location = new System.Drawing.Point(7, 62);
            this.lblWeightCategoryTitle.Name = "lblWeightCategoryTitle";
            this.lblWeightCategoryTitle.Size = new System.Drawing.Size(86, 13);
            this.lblWeightCategoryTitle.TabIndex = 1;
            this.lblWeightCategoryTitle.Text = "Weight Category";
            // 
            // lblYourBMI
            // 
            this.lblYourBMI.AutoSize = true;
            this.lblYourBMI.Location = new System.Drawing.Point(7, 31);
            this.lblYourBMI.Name = "lblYourBMI";
            this.lblYourBMI.Size = new System.Drawing.Size(26, 13);
            this.lblYourBMI.TabIndex = 0;
            this.lblYourBMI.Text = "BMI";
            // 
            // groupBoxBMI
            // 
            this.groupBoxBMI.Controls.Add(this.txtHeightFt);
            this.groupBoxBMI.Controls.Add(this.lblHeight);
            this.groupBoxBMI.Controls.Add(this.lblName);
            this.groupBoxBMI.Controls.Add(this.txtName);
            this.groupBoxBMI.Controls.Add(this.lblWeight);
            this.groupBoxBMI.Controls.Add(this.txtWeight);
            this.groupBoxBMI.Controls.Add(this.txtHeight);
            this.groupBoxBMI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBMI.Name = "groupBoxBMI";
            this.groupBoxBMI.Size = new System.Drawing.Size(295, 100);
            this.groupBoxBMI.TabIndex = 9;
            this.groupBoxBMI.TabStop = false;
            this.groupBoxBMI.Text = "BMI Calculator";
            // 
            // txtHeightFt
            // 
            this.txtHeightFt.Location = new System.Drawing.Point(153, 46);
            this.txtHeightFt.Name = "txtHeightFt";
            this.txtHeightFt.Size = new System.Drawing.Size(65, 20);
            this.txtHeightFt.TabIndex = 4;
            this.txtHeightFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxSaving
            // 
            this.groupBoxSaving.Controls.Add(this.txtFees);
            this.groupBoxSaving.Controls.Add(this.txtGrowthRate);
            this.groupBoxSaving.Controls.Add(this.txtPeriod);
            this.groupBoxSaving.Controls.Add(this.txtMonthlyDeposit);
            this.groupBoxSaving.Controls.Add(this.txtInitialDeposit);
            this.groupBoxSaving.Controls.Add(this.lblFees);
            this.groupBoxSaving.Controls.Add(this.lblGrowth);
            this.groupBoxSaving.Controls.Add(this.lblPeriod);
            this.groupBoxSaving.Controls.Add(this.lblMonthlyDeposit);
            this.groupBoxSaving.Controls.Add(this.lblInitialDeposit);
            this.groupBoxSaving.Location = new System.Drawing.Point(470, 12);
            this.groupBoxSaving.Name = "groupBoxSaving";
            this.groupBoxSaving.Size = new System.Drawing.Size(295, 155);
            this.groupBoxSaving.TabIndex = 10;
            this.groupBoxSaving.TabStop = false;
            this.groupBoxSaving.Text = "Saving plan";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(172, 127);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(117, 20);
            this.txtFees.TabIndex = 9;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGrowthRate
            // 
            this.txtGrowthRate.Location = new System.Drawing.Point(172, 100);
            this.txtGrowthRate.Name = "txtGrowthRate";
            this.txtGrowthRate.Size = new System.Drawing.Size(117, 20);
            this.txtGrowthRate.TabIndex = 8;
            this.txtGrowthRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(172, 73);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(117, 20);
            this.txtPeriod.TabIndex = 7;
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonthlyDeposit
            // 
            this.txtMonthlyDeposit.Location = new System.Drawing.Point(172, 46);
            this.txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            this.txtMonthlyDeposit.Size = new System.Drawing.Size(117, 20);
            this.txtMonthlyDeposit.TabIndex = 6;
            this.txtMonthlyDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(172, 19);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(117, 20);
            this.txtInitialDeposit.TabIndex = 5;
            this.txtInitialDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(6, 130);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(52, 13);
            this.lblFees.TabIndex = 4;
            this.lblFees.Text = "Fees in %";
            // 
            // lblGrowth
            // 
            this.lblGrowth.AutoSize = true;
            this.lblGrowth.Location = new System.Drawing.Point(6, 103);
            this.lblGrowth.Name = "lblGrowth";
            this.lblGrowth.Size = new System.Drawing.Size(118, 13);
            this.lblGrowth.TabIndex = 3;
            this.lblGrowth.Text = "Growth (or interest) in %";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(6, 76);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(71, 13);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "Period (years)";
            // 
            // lblMonthlyDeposit
            // 
            this.lblMonthlyDeposit.AutoSize = true;
            this.lblMonthlyDeposit.Location = new System.Drawing.Point(6, 49);
            this.lblMonthlyDeposit.Name = "lblMonthlyDeposit";
            this.lblMonthlyDeposit.Size = new System.Drawing.Size(81, 13);
            this.lblMonthlyDeposit.TabIndex = 1;
            this.lblMonthlyDeposit.Text = "Monthly deposit";
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Location = new System.Drawing.Point(6, 22);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(68, 13);
            this.lblInitialDeposit.TabIndex = 0;
            this.lblInitialDeposit.Text = "Initial deposit";
            // 
            // btnCalcSavings
            // 
            this.btnCalcSavings.Location = new System.Drawing.Point(470, 178);
            this.btnCalcSavings.Name = "btnCalcSavings";
            this.btnCalcSavings.Size = new System.Drawing.Size(295, 23);
            this.btnCalcSavings.TabIndex = 11;
            this.btnCalcSavings.Text = "Calculate Savings";
            this.btnCalcSavings.UseVisualStyleBackColor = true;
            this.btnCalcSavings.Click += new System.EventHandler(this.btnCalcSavings_Click);
            // 
            // groupBoxFutureValue
            // 
            this.groupBoxFutureValue.Controls.Add(this.lblTotalFees);
            this.groupBoxFutureValue.Controls.Add(this.lblFinalBalance);
            this.groupBoxFutureValue.Controls.Add(this.lblAmountEarned);
            this.groupBoxFutureValue.Controls.Add(this.lblAmountPaid);
            this.groupBoxFutureValue.Controls.Add(this.label5);
            this.groupBoxFutureValue.Controls.Add(this.label4);
            this.groupBoxFutureValue.Controls.Add(this.label2);
            this.groupBoxFutureValue.Controls.Add(this.label1);
            this.groupBoxFutureValue.Location = new System.Drawing.Point(470, 207);
            this.groupBoxFutureValue.Name = "groupBoxFutureValue";
            this.groupBoxFutureValue.Size = new System.Drawing.Size(295, 135);
            this.groupBoxFutureValue.TabIndex = 12;
            this.groupBoxFutureValue.TabStop = false;
            this.groupBoxFutureValue.Text = "Future value";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Location = new System.Drawing.Point(172, 103);
            this.lblTotalFees.MinimumSize = new System.Drawing.Size(117, 15);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(117, 15);
            this.lblTotalFees.TabIndex = 7;
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.AutoSize = true;
            this.lblFinalBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinalBalance.Location = new System.Drawing.Point(172, 76);
            this.lblFinalBalance.MinimumSize = new System.Drawing.Size(117, 15);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(117, 15);
            this.lblFinalBalance.TabIndex = 6;
            this.lblFinalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountEarned
            // 
            this.lblAmountEarned.AutoSize = true;
            this.lblAmountEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountEarned.Location = new System.Drawing.Point(172, 49);
            this.lblAmountEarned.MinimumSize = new System.Drawing.Size(117, 15);
            this.lblAmountEarned.Name = "lblAmountEarned";
            this.lblAmountEarned.Size = new System.Drawing.Size(117, 15);
            this.lblAmountEarned.TabIndex = 5;
            this.lblAmountEarned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountPaid.Location = new System.Drawing.Point(172, 22);
            this.lblAmountPaid.MinimumSize = new System.Drawing.Size(117, 15);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(117, 15);
            this.lblAmountPaid.TabIndex = 4;
            this.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Final balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount earned";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount paid";
            // 
            // groupBoxBMR
            // 
            this.groupBoxBMR.Controls.Add(this.listBoxBMR);
            this.groupBoxBMR.Controls.Add(this.btnCalcBMR);
            this.groupBoxBMR.Controls.Add(this.groupBoxActivityLevel);
            this.groupBoxBMR.Controls.Add(this.txtAge);
            this.groupBoxBMR.Controls.Add(this.label6);
            this.groupBoxBMR.Controls.Add(this.groupBoxGender);
            this.groupBoxBMR.Location = new System.Drawing.Point(12, 348);
            this.groupBoxBMR.Name = "groupBoxBMR";
            this.groupBoxBMR.Size = new System.Drawing.Size(753, 205);
            this.groupBoxBMR.TabIndex = 13;
            this.groupBoxBMR.TabStop = false;
            this.groupBoxBMR.Text = "BMR Calculator";
            // 
            // listBoxBMR
            // 
            this.listBoxBMR.Font = new System.Drawing.Font("Courier New", 9F);
            this.listBoxBMR.FormattingEnabled = true;
            this.listBoxBMR.ItemHeight = 15;
            this.listBoxBMR.Location = new System.Drawing.Point(359, 26);
            this.listBoxBMR.Name = "listBoxBMR";
            this.listBoxBMR.Size = new System.Drawing.Size(388, 139);
            this.listBoxBMR.TabIndex = 5;
            // 
            // btnCalcBMR
            // 
            this.btnCalcBMR.Location = new System.Drawing.Point(99, 176);
            this.btnCalcBMR.Name = "btnCalcBMR";
            this.btnCalcBMR.Size = new System.Drawing.Size(254, 23);
            this.btnCalcBMR.TabIndex = 4;
            this.btnCalcBMR.Text = "Calculate BMR";
            this.btnCalcBMR.UseVisualStyleBackColor = true;
            this.btnCalcBMR.Click += new System.EventHandler(this.btnCalcBMR_Click);
            // 
            // groupBoxActivityLevel
            // 
            this.groupBoxActivityLevel.Controls.Add(this.rbtnActivityExtra);
            this.groupBoxActivityLevel.Controls.Add(this.rbtnActivityVery);
            this.groupBoxActivityLevel.Controls.Add(this.rbtnActivityModerate);
            this.groupBoxActivityLevel.Controls.Add(this.rbtnActivityLight);
            this.groupBoxActivityLevel.Controls.Add(this.rbtnActivitySedentary);
            this.groupBoxActivityLevel.Location = new System.Drawing.Point(99, 20);
            this.groupBoxActivityLevel.Name = "groupBoxActivityLevel";
            this.groupBoxActivityLevel.Size = new System.Drawing.Size(254, 150);
            this.groupBoxActivityLevel.TabIndex = 3;
            this.groupBoxActivityLevel.TabStop = false;
            this.groupBoxActivityLevel.Text = "Weekly activity level";
            // 
            // rbtnActivityExtra
            // 
            this.rbtnActivityExtra.AutoSize = true;
            this.rbtnActivityExtra.Location = new System.Drawing.Point(7, 116);
            this.rbtnActivityExtra.Name = "rbtnActivityExtra";
            this.rbtnActivityExtra.Size = new System.Drawing.Size(222, 17);
            this.rbtnActivityExtra.TabIndex = 4;
            this.rbtnActivityExtra.TabStop = true;
            this.rbtnActivityExtra.Text = "Extra active, Hard exercise or physical job";
            this.rbtnActivityExtra.UseVisualStyleBackColor = true;
            // 
            // rbtnActivityVery
            // 
            this.rbtnActivityVery.AutoSize = true;
            this.rbtnActivityVery.Location = new System.Drawing.Point(7, 92);
            this.rbtnActivityVery.Name = "rbtnActivityVery";
            this.rbtnActivityVery.Size = new System.Drawing.Size(219, 17);
            this.rbtnActivityVery.TabIndex = 3;
            this.rbtnActivityVery.TabStop = true;
            this.rbtnActivityVery.Text = "Very active, Exercise 6 to 7 times a week";
            this.rbtnActivityVery.UseVisualStyleBackColor = true;
            // 
            // rbtnActivityModerate
            // 
            this.rbtnActivityModerate.AutoSize = true;
            this.rbtnActivityModerate.Location = new System.Drawing.Point(7, 68);
            this.rbtnActivityModerate.Name = "rbtnActivityModerate";
            this.rbtnActivityModerate.Size = new System.Drawing.Size(244, 17);
            this.rbtnActivityModerate.TabIndex = 2;
            this.rbtnActivityModerate.TabStop = true;
            this.rbtnActivityModerate.Text = "Moderatly active, Exercise 4 to 5 times a week";
            this.rbtnActivityModerate.UseVisualStyleBackColor = true;
            // 
            // rbtnActivityLight
            // 
            this.rbtnActivityLight.AutoSize = true;
            this.rbtnActivityLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtnActivityLight.Location = new System.Drawing.Point(7, 44);
            this.rbtnActivityLight.Name = "rbtnActivityLight";
            this.rbtnActivityLight.Size = new System.Drawing.Size(228, 17);
            this.rbtnActivityLight.TabIndex = 1;
            this.rbtnActivityLight.TabStop = true;
            this.rbtnActivityLight.Text = "Lightly active, Exercise 1 to 3 times a week";
            this.rbtnActivityLight.UseVisualStyleBackColor = true;
            // 
            // rbtnActivitySedentary
            // 
            this.rbtnActivitySedentary.AutoSize = true;
            this.rbtnActivitySedentary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtnActivitySedentary.Location = new System.Drawing.Point(7, 20);
            this.rbtnActivitySedentary.Name = "rbtnActivitySedentary";
            this.rbtnActivitySedentary.Size = new System.Drawing.Size(170, 17);
            this.rbtnActivitySedentary.TabIndex = 0;
            this.rbtnActivitySedentary.TabStop = true;
            this.rbtnActivitySedentary.Text = "Sedentary, Little or no exercise";
            this.rbtnActivitySedentary.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(56, 98);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(37, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Age";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.rbtnMale);
            this.groupBoxGender.Controls.Add(this.rbtnFemale);
            this.groupBoxGender.Location = new System.Drawing.Point(7, 20);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(86, 74);
            this.groupBoxGender.TabIndex = 0;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(7, 44);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(7, 20);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 0;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 558);
            this.Controls.Add(this.groupBoxBMR);
            this.Controls.Add(this.groupBoxFutureValue);
            this.Controls.Add(this.btnCalcSavings);
            this.Controls.Add(this.groupBoxSaving);
            this.Controls.Add(this.groupBoxBMI);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.groupBoxUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Calculator Calculator by Carl Lindman";
            this.groupBoxUnit.ResumeLayout(false);
            this.groupBoxUnit.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.groupBoxBMI.ResumeLayout(false);
            this.groupBoxBMI.PerformLayout();
            this.groupBoxSaving.ResumeLayout(false);
            this.groupBoxSaving.PerformLayout();
            this.groupBoxFutureValue.ResumeLayout(false);
            this.groupBoxFutureValue.PerformLayout();
            this.groupBoxBMR.ResumeLayout(false);
            this.groupBoxBMR.PerformLayout();
            this.groupBoxActivityLevel.ResumeLayout(false);
            this.groupBoxActivityLevel.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox groupBoxUnit;
        private System.Windows.Forms.RadioButton rbtnUsUnit;
        private System.Windows.Forms.RadioButton rbtnMetricUnit;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label lblWeightCategoryTitle;
        private System.Windows.Forms.Label lblYourBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.GroupBox groupBoxBMI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNormalRange;
        private System.Windows.Forms.Label lblWeightCategory;
        private System.Windows.Forms.TextBox txtHeightFt;
        private System.Windows.Forms.GroupBox groupBoxSaving;
        private System.Windows.Forms.Label lblInitialDeposit;
        private System.Windows.Forms.Label lblMonthlyDeposit;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtGrowthRate;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtMonthlyDeposit;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblGrowth;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Button btnCalcSavings;
        private System.Windows.Forms.GroupBox groupBoxFutureValue;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Label lblAmountEarned;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxBMR;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.ListBox listBoxBMR;
        private System.Windows.Forms.Button btnCalcBMR;
        private System.Windows.Forms.GroupBox groupBoxActivityLevel;
        private System.Windows.Forms.RadioButton rbtnActivityVery;
        private System.Windows.Forms.RadioButton rbtnActivityModerate;
        private System.Windows.Forms.RadioButton rbtnActivityLight;
        private System.Windows.Forms.RadioButton rbtnActivitySedentary;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnActivityExtra;
    }
}

