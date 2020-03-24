namespace GradeBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}