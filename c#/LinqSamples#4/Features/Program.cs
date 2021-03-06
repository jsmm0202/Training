using System.Collections.Generic;
using System.Linq;

namespace Features
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" },
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" },
            };

            var query = developers.Where(e => e.Name.Length == 5).OrderBy(e => e.Name);

            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;

            foreach (var employee in query2)
            {
                System.Console.WriteLine(employee.Name);
            }
        }
    }
}
