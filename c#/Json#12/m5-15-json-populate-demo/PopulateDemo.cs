using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m5.d15
{
    public static class PopulateDemo
    {
        public static void ShowPopulate()
        {
            Console.Clear();
            Console.WriteLine("*** PopulateObject ***");

            //Generate test data
            List<UserInteraction> userLogs = GetTestData();

            string jsonReviewed = @"{
'reviewed': true,
'processedBy': ['ReviewerProcess'],
'reviewedDate': '" + DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssK") + @"' 
}";
            Console.WriteLine(jsonReviewed);

            Console.WriteLine("- Populate values");
            foreach (UserInteraction log in userLogs)
            {
                JsonConvert.PopulateObject(jsonReviewed, log);
            }
            Console.WriteLine("Reviewed: " + userLogs[0].reviewed);
            Console.WriteLine("Reviewed Date: " + userLogs[0].reviewedDate);
            Console.WriteLine("Processed By: " + String.Join(" | ", userLogs[0].processedBy));
        }

        private static List<UserInteraction> GetTestData()
        {
            List<UserInteraction> userLogs = new List<UserInteraction>();
            for (int i = 0; i < 100; i++)
            {
                UserInteraction uI = new UserInteraction();
                uI.GenerateFakeLog();
                userLogs.Add(uI);
            }
            return userLogs;
        }
    }
}
