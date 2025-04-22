using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Logger
    {
       
            public static void LogToEventViewer(string message)
            {
                string source = "BusinessManagementSystem";
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, "Application");
                }
                EventLog.WriteEntry(source, message, EventLogEntryType.Error);
            }
        
    }
}
