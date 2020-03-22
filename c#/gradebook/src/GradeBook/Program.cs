using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        { 
            Book book = new Book("Jessi's Grade Book");
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);

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
                    System.Console.WriteLine(ex.Message);
                }

            }
            
            book.ShowStatistics();
        }
    }
}
