namespace GradeBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name)
            : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();

        public abstract void ShowStatistics();
    }
}