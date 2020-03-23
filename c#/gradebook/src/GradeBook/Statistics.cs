using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Avarage
        {
            get
            {
                return Sum / count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch (Avarage)
                {
                    case var d when d >= 90.0:
                        return 'A';

                    case var d when d >= 80.0:
                        return 'B';

                    case var d when d >= 70.0:
                        return 'C';

                    case var d when d >= 60.0:
                        return 'D';

                    default:
                        return 'F';
                }
            }
        }
        public double Sum;
        public int count;

        public Statistics()
        {
            count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            count++;
            High = Math.Max(High, number);
            Low = Math.Min(Low, number);
        }
    }
}