using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Uni.Educational.IoC;
using Uni.Educational.IoC.Services;

namespace Uni.Educational
{
    public class Logger : ILogger
    {
        public Logger()
        {

        }
        public void LogError(string message)
        {
            //EventLog.WriteEntry("Ariadne", message, EventLogEntryType.Error);
        }
        public void LogInfo(string message)
        {
            //EventLog.WriteEntry("Ariadne", message, EventLogEntryType.Information);
        }
        public void LogException(Exception exception)
        {
            //EventLog.WriteEntry("Ariadne", exception.StackTrace, EventLogEntryType.Error);
        }
        public ApplicationContext ApplicationContext { get; set; }

        public void Initialize()
        {
        }

        public void Shutdown()
        {
        }
    }
}
