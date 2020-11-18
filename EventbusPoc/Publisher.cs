using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventbusPoc
{
    public class Publisher : IPublisher
    {
        private readonly IEnumerable<IDelegatingProducer> _delegatingProducers;

        public Publisher(IEnumerable<IDelegatingProducer> delegatingProducers)
        {
            _delegatingProducers = delegatingProducers;

            for (int i = 0; i < _delegatingProducers.Count() - 1; i++)
            {
                _delegatingProducers.ElementAt(i).InnerProducer = _delegatingProducers.ElementAt(i+1);
            }
        }

        public async Task PublishAsync<T>(T integrationEvent, IDictionary<string, string> headers)
        {
            await _delegatingProducers.ElementAt(0).ProducerAsync(integrationEvent, headers);
        }
    }
}
