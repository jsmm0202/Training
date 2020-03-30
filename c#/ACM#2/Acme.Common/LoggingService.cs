namespace Acme.Common
{
    using System;
    using System.Collections.Generic;

    public class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsToLog) // use 'IEnumerable' and read about extenstions methods
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
