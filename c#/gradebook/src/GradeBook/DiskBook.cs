namespace GradeBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class DiskBook : Book
    {
        public DiskBook(string name)
            : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            using (var reader = File.OpenText($"{Name}.txt"))
            {
                string s = string.Empty;
                while ((s = reader.ReadLine()) != null)
                {
                    result.Add(double.Parse(s));
                }
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