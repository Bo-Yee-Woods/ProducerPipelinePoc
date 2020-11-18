using EventbusPoc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProducerPipelinePoc.DelegatingProducers
{
    public class TokenizationDelegatingProducer : IDelegatingProducer
    {
        public IDelegatingProducer InnerProducer { get; set; }

        public async Task ProducerAsync<TEvent>(TEvent integrationEvent, IDictionary<string, string> headers)
        {
            Console.WriteLine("tokenization");

            await InnerProducer.ProducerAsync(integrationEvent, headers);
        }
    }
}
