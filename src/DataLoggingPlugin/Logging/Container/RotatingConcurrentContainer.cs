using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataLoggingPlugin.Logging.Container
{
    class RotatingConcurrentContainer<T>
    {
        private List<T> _currentList;
        private List<T> _rotateList;

        private object _lock = new object();

        public RotatingConcurrentContainer()
        {
            _currentList = new List<T>();
            _rotateList = new List<T>();
        }

        public void Add(T item)
        {
            lock (_lock)
            {
                _currentList.Add(item);
            }
        }

        public ReadOnlyCollection<T> Collection
        {
            get
            {
                lock (_lock)
                {
                    var current = _currentList;
                    var rotate = _rotateList;

                    _rotateList = current;
                    _currentList = rotate;

                    var returnObj = new List<T>(current).AsReadOnly();
                    current.Clear();
                    rotate.Clear();
                    return returnObj;
                }
            }
        }
    }
}
