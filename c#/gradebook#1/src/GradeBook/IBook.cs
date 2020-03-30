namespace GradeBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IBook
    {
        event GradeAddedDelegate GradeAdded;

        string Name { get; }

        void AddGrade(double grade);

        Statistics GetStatistics();

        void ShowStatistics();
    }
}
