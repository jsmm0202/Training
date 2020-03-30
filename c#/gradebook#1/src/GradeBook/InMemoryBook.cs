namespace GradeBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class InMemoryBook : Book
    {
        public const string CATEGORY = "Science";

        private readonly List<double> _grades;

        public InMemoryBook(string name)
            : base(name)
        {
            _grades = new List<double>();
        }

        public override event GradeAddedDelegate GradeAdded;

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException("Invalid grade");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            foreach (var grade in _grades)
            {
                result.Add(grade);
            }

            return result;
        }

        public override void ShowStatistics()
        {
            Statistics result = GetStatistics();

            Console.WriteLine($"For the book named {Name}");
            Console.WriteLine($"The lowest grade is {result.Low}");
            Console.WriteLine($"The highest grade is {result.High}");
            Console.WriteLine($"The avarage grade is {result.Avarage}");
            Console.WriteLine($"The letter grade is {result.Letter}");
        }
    }
}