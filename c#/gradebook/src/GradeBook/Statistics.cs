namespace GradeBook
{
    using System;

    public class Statistics
    {
        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public double Avarage
        {
            get
            {
                return Sum / Count;
            }
        }

        public double High { get; set; }

        public double Low { get; set; }

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

        public double Sum { get; set; }

        public int Count { get; set; }

        public void Add(double number)
        {
            Sum += number;
            Count++;
            High = Math.Max(High, number);
            Low = Math.Min(Low, number);
        }
    }
}