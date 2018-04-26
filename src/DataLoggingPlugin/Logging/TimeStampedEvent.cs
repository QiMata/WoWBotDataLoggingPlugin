using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wManager.Wow.ObjectManager;

namespace DataLoggingPlugin.Logging
{
    class TimeStampedEvent
    {
        protected TimeStampedEvent(){}

        public string CharacterName { get; set; } = ObjectManager.Me.Name;

        public string Server { get; set; }

        public DateTimeOffset Timestamp { get; } = DateTimeOffset.Now;

        public object Record { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public IDictionary<string,object> AdditionalMetadata { get; set; }
    }

    class TimeStampedEvent<T> : TimeStampedEvent
    {
        public new T Record
        {
            get => (T) base.Record;
            set => base.Record = value;
        }
    }
}
