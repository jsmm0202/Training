using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = MyLinq.Random().Where(n => n > 0.5).Take(10);
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight", Rating = 8.9f, Year = 2008 },
                new Movie { Title = "The king's Speech", Rating = 8.0f, Year = 2010 },
                new Movie { Title = "Casablanca", Rating = 8.5f, Year = 1942 },
                new Movie { Title = "Star wars V", Rating = 8.7f, Year = 1980 },
            };

            var query = movies.Filter(m => m.Year > 2000).ToList();
            System.Console.WriteLine(query.Count());
            foreach (var movie in query)
            {
                System.Console.WriteLine(movie.Title);
            }
        }
    }
}
