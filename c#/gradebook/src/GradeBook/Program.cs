using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        { 
            Book book = new Book("Jessi's Grade Book");
            book.GradeAdded += OnGradeAdded;

            var input = "";
            var grade = 0.0;
            while(true)
            {
                System.Console.WriteLine("please enter a grade or 'q' to quit");            
                input = Console.ReadLine();
                if(input == "q"){
                    break;
                }
                try{
                    grade = double.Parse(input);
                    book.AddGrade(grade);   
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            
            book.ShowStatistics();
        }

        static void OnGradeAdded(object sender, EventArgs args){
            Console.WriteLine("A grade was added");
        }
    }
}
