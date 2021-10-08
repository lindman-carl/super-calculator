namespace Assignment3
{
    class BMRCalculator
    {
        private int age;
        private int activityLevel;
        private double weight; // must be kg
        private double height; // must be cm
        private bool isFemale;
        private UnitTypes unit = UnitTypes.American;

        public double[] GetValues()
        {
            // Init bmr factors in an array where each index corresponds to the activity level
            double[] bmrFactors = new double[] { 1.2, 1.375, 1.550, 1.725, 1.9 };

            double bmr = CalculateBMR();
            double maintainWeight = bmr * bmrFactors[activityLevel];

            return new double[] { bmr, maintainWeight };
        }
        private double CalculateBMR()
        {
            double bmr;

            bmr = (10 * weight) + (6.25 * height) - (5 * age);

            // ternary operator for isFemale, if true -161 else +5
            bmr += isFemale ? -161 : 5;

            return bmr;
        }

        // Getters and setters
        public int Age
        {
            get => age;
            set => age = value;
        }
        public int ActivityLevel
        {
            get => activityLevel;
            set => activityLevel = value;
        }
        public double Weight
        {
            get => weight;
            set
            {
                if (unit == UnitTypes.Metric)
                {
                    weight = value;
                }
                else
                {
                    // Convert lbs to kg
                    weight = value * 0.45359237;
                }
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (unit == UnitTypes.Metric)
                {
                    height = value;
                }
                else
                {
                    // Convert inches to cm
                    height = value * 2.54;
                }
            }
        }
        public bool Female
        {
            get => isFemale;
            set => isFemale = value;
        }
        public UnitTypes Unit
        {
            get => unit;
            set => unit = value;
        }
    }
}
