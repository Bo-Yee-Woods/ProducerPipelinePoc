using EventbusPoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProducerPipelinePoc.DelegatingProducers
{
    public class RtDelegatingProducer : IDelegatingProducer
    {
        public IDelegatingProducer InnerProducer { get; set; }

        public async Task ProducerAsync<TEvent>(TEvent integrationEvent, IDictionary<string, string> headers)
        {
            Console.WriteLine("add rt operation context info to header");

            await InnerProducer.ProducerAsync(integrationEvent, headers);
        }
    }
}
