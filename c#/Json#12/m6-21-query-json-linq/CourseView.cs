using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d21
{
    class CourseView
    {
        public int userId { get; set; }

        public string user{ get; set; }

        public string course { get; set; }

        public DateTime watchedDate { get; set; }

        public int secondsWatched { get; set; }
    }
}
