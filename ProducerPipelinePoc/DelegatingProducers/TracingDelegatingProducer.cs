using EventbusPoc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProducerPipelinePoc.DelegatingProducers
{
    public class TracingDelegatingProducer : IDelegatingProducer
    {
        public IDelegatingProducer InnerProducer { get; set; }

        public async Task ProducerAsync<TEvent>(TEvent integrationEvent, IDictionary<string, string> headers)
        {
            Console.WriteLine("activity start");

            Console.WriteLine("add operationId and operation_parent_id to headers");

            await InnerProducer.ProducerAsync(integrationEvent, headers);

            Console.WriteLine("activity stop");
        }
    }
}
