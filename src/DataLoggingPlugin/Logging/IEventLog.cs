using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLoggingPlugin.Logging
{
    interface IEventLog : IDisposable
    {
        void Log(TimeStampedEvent stampedEvent);

        void Log<T>(TimeStampedEvent<T> stampedEvent);
    }
}
