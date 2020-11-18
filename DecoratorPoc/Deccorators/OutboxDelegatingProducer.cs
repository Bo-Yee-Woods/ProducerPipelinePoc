using EventbusPoc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProducerPipelinePoc.DelegatingProducers
{
    public class OutboxDelegatingProducer : IDelegatingProducer
    {
        public IDelegatingProducer InnerProducer { get; set; }

        public async Task ProducerAsync<TEvent>(TEvent integrationEvent, IDictionary<string, string> headers)
        {
            Console.WriteLine("save outgoing event");

            await InnerProducer.ProducerAsync(integrationEvent, headers);

            Console.WriteLine("update outgoing event to sent");
        }
    }
}
