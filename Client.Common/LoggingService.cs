using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Common
{
    class LoggingService
    {
        public static void WriteToFile (List<ILoggable> Logs)
        {
            foreach (var item in Logs)
            {
                Console.WriteLine(item.Log());
            }

        }
    }
}
