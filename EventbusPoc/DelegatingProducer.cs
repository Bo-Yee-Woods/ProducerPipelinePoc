using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventbusPoc
{
    public class DelegatingProducer : IDelegatingProducer
    {
        public IDelegatingProducer InnerProducer { get; set; }

        public async Task ProducerAsync<TEvent>(TEvent integrationEvent, IDictionary<string, string> headers)
        {
            await InnerProducer.ProducerAsync(integrationEvent, headers);
        }
    }
}
