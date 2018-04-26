using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataLoggingPlugin.Logging.Container
{
    class ConcurrentTypeContainer
    {
        private readonly IDictionary<Type, object> _concurrentContainers;

        public ConcurrentTypeContainer()
        {
            _concurrentContainers = new ConcurrentDictionary<Type, object>();
        }

        public void Add<T>(TimeStampedEvent<T> item)
        {
            if (!_concurrentContainers.ContainsKey(typeof(T)))
            {
                _concurrentContainers[typeof(T)] = new RotatingConcurrentContainer<TimeStampedEvent>();
            }

            ((RotatingConcurrentContainer<TimeStampedEvent>)_concurrentContainers[typeof(T)]).Add(item);
        }

        public IEnumerable<Type> Types => _concurrentContainers.Keys;
        
        public ReadOnlyCollection<TimeStampedEvent> GetCollection(Type type)
        {
            return ((RotatingConcurrentContainer<TimeStampedEvent>)_concurrentContainers[type]).Collection;
        }
    }
}
