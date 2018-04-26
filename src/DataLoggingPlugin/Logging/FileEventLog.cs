using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace DataLoggingPlugin.Logging
{
    class FileEventLog : IEventLog
    {
        private readonly string _filePath;
        private readonly Timer _timer;
        private ConcurrentQueue<TimeStampedEvent> _timeStampedEvents;
        private object _lock;

        public FileEventLog(string filePath)
        {
            _filePath = filePath;
            _timeStampedEvents = new ConcurrentQueue<TimeStampedEvent>();
            _lock = new object();

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            _timer = new Timer(x => { LogOutToFile(); }, null,TimeSpan.FromSeconds(1),TimeSpan.FromSeconds(1));
        }

        private void LogOutToFile()
        {
            lock (_lock)
            {
                using (var file = File.OpenWrite(_filePath))
                {
                    while (_timeStampedEvents.TryDequeue(out var stampedEvent))
                    {
                        var json = JsonConvert.SerializeObject(stampedEvent);
                        var bytes = Encoding.UTF8.GetBytes(json);
                        file.Write(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        public void Log(TimeStampedEvent stampedEvent)
        {
            _timeStampedEvents.Enqueue(stampedEvent);
        }

        public void Log<T>(TimeStampedEvent<T> stampedEvent)
        {
            _timeStampedEvents.Enqueue(stampedEvent);
        }

        public void Dispose()
        {
            _timer?.Dispose();
            LogOutToFile();
        }
    }
}
