namespace Assignment3
{
    class BMICalculator
    {
        private double height = 0; // m or in 
        private double weight = 0;
        private UnitTypes unit = UnitTypes.American;

        public double CalculateBMI()
        {
            double bmi = 0;

            if (unit == UnitTypes.Metric)
            {
                // Calculate bmi with metric types
                bmi = weight / (height * height);
            } 
            else if (unit == UnitTypes.American)
            {
                // Calculate imperial bmi
                bmi = 703 * weight / (height * height);
            }

            return bmi;
        }

        public double[] CalculateNormalBMI()
        {
            double lowerWeight = 0;
            double higherWeight = 0;

            if (unit == UnitTypes.Metric)
            {
                lowerWeight = 18.5 * (height * height);
                higherWeight = 24.9 * (height * height);
            }
            else if (unit == UnitTypes.American)
            {
                lowerWeight = 18.5 * (height * height) / 703;
                higherWeight = 24.9 * (height * height) / 703;
            }

            return new double[2] { lowerWeight, higherWeight };
        }
        // Getters and setters
        public double Height
        {
            get => height;
            set
            {
                if (unit == UnitTypes.Metric)
                {
                    // if metric divide by 100 to get meters
                    height = value / 100;
                } 
                else if (unit == UnitTypes.American)
                {
                    height = value;
                }
            }
        }

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public UnitTypes Unit
        {
            get => unit;
            set => unit = value;
        }

    }
}
