using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.EventHubs;
using Newtonsoft.Json;

namespace DataLoggingPlugin.Logging.IoTHub
{
    class EventHubLogger : IEventLog
    {
        private EventHubClient _eventHubClient;
        private ConcurrentQueue<TimeStampedEvent> _timeStampedEvents = new ConcurrentQueue<TimeStampedEvent>();
        private Task _backgroundTask;
        private bool _run;

        public EventHubLogger(string connectionString)
        {
            EventHubsConnectionStringBuilder connectionStringBuilder = new EventHubsConnectionStringBuilder(connectionString)
            {
                EntityPath = "bothub"
            };
            _eventHubClient = EventHubClient.CreateFromConnectionString(connectionStringBuilder.ToString());
            _run = true;
            _backgroundTask = Run();
        }

        private async Task Run()
        { 
            while (_run)
            {
                try
                {
                    if (_timeStampedEvents.TryDequeue(out var timeStamped))
                    {
                            await _eventHubClient.SendAsync(
                                new EventData(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(timeStamped,new JsonSerializerSettings
                                {
                                    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                                    DateParseHandling = DateParseHandling.DateTimeOffset
                                }))));
                            robotManager.Helpful.Logging.WriteDebug($"Uploading Event Hub Data for {timeStamped.Type}");
                        
                    }
                    else
                    {
                        await Task.Delay(TimeSpan.FromMilliseconds(100));
                    }
                }
                catch (Exception )
                {
                    //try to catch all exceptions
                }
            }
        }

        public void Dispose()
        {
            _run = false;
        }

        public void Log(TimeStampedEvent stampedEvent)
        {
            _timeStampedEvents.Enqueue(stampedEvent);
        }

        public void Log<T>(TimeStampedEvent<T> stampedEvent)
        {
            _timeStampedEvents.Enqueue(stampedEvent);
        }
    }
}
