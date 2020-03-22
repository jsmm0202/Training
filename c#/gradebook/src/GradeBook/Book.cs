using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class Book
    { 
        public Book(string name){
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(char letter)
        {
            switch(letter)
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

        public void AddGrade(double grade)
        {
            if(grade >= 0 && grade <=100){
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException("Invalid grade");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Avarage = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(result.High,grade);
                result.Low = Math.Min(result.Low, grade);
                result.Avarage += grade;
            }
            result.Avarage /= grades.Count;

            switch(result.Avarage)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

        public void ShowStatistics()
        {
            Statistics result = GetStatistics();

            Console.WriteLine($"For the book named {Name}");
            Console.WriteLine($"The lowest grade is {result.Low}");
            Console.WriteLine($"The highest grade is {result.High}");
            Console.WriteLine($"The avarage grade is {result.Avarage}");
            Console.WriteLine($"The letter grade is {result.Letter}");
        }

        public event GradeAddedDelegate GradeAdded;

        public string Name{
            get;
            set;
        }

        public const string CATEGORY = "Science";
        private List<double> grades;
    }
}