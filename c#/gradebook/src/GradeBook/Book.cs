using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    { 
        public Book(string name){
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade >= 0 && grade <=100){
                grades.Add(grade);
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

            return result;
        }

        public void ShowStatistics()
        {
            Statistics result = GetStatistics();

            Console.WriteLine($"The lowest grade is {result.Low}");
            Console.WriteLine($"The highest grade is {result.High}");
            Console.WriteLine($"The avarage grade is {result.Avarage}");
        }

        public string Name;

        private List<double> grades;
    }
}