using System;

namespace Assignment3
{
    class SavingsCalculator
    {
        private double initialDeposit;
        private double monthlyDeposit;
        private double period; // Lazyiness means it's a double instead of int.
        private double growthRate; // yearly
        private double feeRate;


        
        public double[] CalculateSavings()
        {
            double amountPaid = initialDeposit;
            double amountEarned = 0;
            double totalFees = 0;

            double interestEarned;
            double feesPaid;
            double balance = initialDeposit;

            for (int i = 0; i < period; i++)
            {
                Console.WriteLine((i + 1) + "/" + period);
                // Calculate interest earned based on previous month's balanance, we do not earn interest until a month has passed
                interestEarned = (growthRate / 12) * balance;

                // Add monthly deposit to balance
                balance += monthlyDeposit + interestEarned;

                // Fees are paid based on the monthly deposit, fees could be stuff like courtage
                feesPaid = (feeRate) * monthlyDeposit;

                // Reduce balance with the fees
                balance -= feesPaid;

                // Keep a tally on the total fees paid and monthly deposits
                amountPaid += monthlyDeposit;
                totalFees += feesPaid;
                amountEarned += interestEarned;
            }

            return new double[] { amountPaid, amountEarned, balance, totalFees };
        }

        // Getters and setters
        public double InitialDeposit
        {
            get => initialDeposit;
            set => initialDeposit = value;
        }
        public double MonthlyDeposit
        {
            get => monthlyDeposit;
            set => monthlyDeposit = value;
        }
        public double Period
        {
            get => period;
            // Convert years to months
            set => period = value * 12;
        }
        public double GrowthRate
        {
            get => growthRate;
            // Divide by 100 to get percentage
            set => growthRate = value / 100;
        }
        public double FeeRate
        {
            get => feeRate;
            // Divide by 100 to get percentage
            set => feeRate = value / 100;
        }
    }
}
