using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    [JsonObject()]
    public class AuthorCoursesEnumerableAttribute : IEnumerable<Course>
    {
        public List<Course> courses { get; set; }
        public AuthorCoursesEnumerableAttribute()
        {
            courses = new List<Course>();
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return courses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class AuthorCoursesEnumerable : IEnumerable<Course>
    {
        public List<Course> courses { get; set; }

        public AuthorCoursesEnumerable()
        {
            courses = new List<Course>();
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return courses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    [JsonArray()]
    public class AuthorCoursesArray : IEnumerable<Course>
    {
        public List<Course> courses { get; set; }
        public AuthorCoursesArray()
        {
            courses = new List<Course>();
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return courses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    [JsonDictionary()]
    public class AuthorCoursesDictionary : IEnumerable<Course>
    {
        public List<Course> courses { get; set; }
        public AuthorCoursesDictionary()
        {
            courses = new List<Course>();
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return courses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class Course
    {
        public string courseName { get; set; }

        public int duration { get; set; }
    }
}
