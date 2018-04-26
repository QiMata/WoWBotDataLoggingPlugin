//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using DataLoggingPlugin.Logging.Container;
//using Nest;

//namespace DataLoggingPlugin.Logging.Elastic
//{
//    class ElaticEventLog : IEventLog
//    {
//        private readonly ConcurrentTypeContainer _typeContainer;
//        private readonly ElasticClient _elasticClient;
//        private readonly Timer _timer;

//        public ElaticEventLog()
//        {
//            _typeContainer = new ConcurrentTypeContainer();
//            var node = new Uri("http://elastic:Deathcloud12@13.68.113.227:9200");
//            var settings = new ConnectionSettings(node);
//            settings.DefaultIndex("wwow");
//            _elasticClient = new ElasticClient(settings);

//            _timer = new Timer(async x =>
//            {
//                await Task.WhenAll(_typeContainer.Types.Select(containerType =>
//                {
//                    var records = _typeContainer.GetCollection(containerType);

//                    if (!records.Any())
//                    {
//                        return Task.CompletedTask;
//                    }

//                    return _elasticClient.IndexManyAsync(records, ("wwow-" + records.First().Type).ToLower());
//                }));
//            },null,TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(5));
//        }

//        public void Dispose()
//        {
//            _timer?.Dispose();
//        }

//        public void Log(TimeStampedEvent stampedEvent)
//        {
//            throw new NotImplementedException();
//        }

//        public void Log<T>(TimeStampedEvent<T> stampedEvent)
//        {
//            _typeContainer.Add(stampedEvent);
//        }
//    }
//}
