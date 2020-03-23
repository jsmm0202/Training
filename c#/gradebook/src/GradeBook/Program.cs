using System;
using System.Collections.Generic;

namespace GradeBook
{    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Jessi's Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            book.ShowStatistics();
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                System.Console.WriteLine("please enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        static void OnGradeAdded(object sender, EventArgs args){
            Console.WriteLine("A grade was added");
        }
    }
}
