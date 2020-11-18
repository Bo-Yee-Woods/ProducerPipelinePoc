using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventbusPoc
{
    public interface IDelegatingProducer
    {
        IDelegatingProducer InnerProducer { get; set; }

        Task ProducerAsync<TEvent>(TEvent integrationEvent, IDictionary<string, string> headers);

        //async Task ProducerAsync<TEvent>(TEvent integrationEvent, IDictionary<string, string> headers)
        //{
        //    await InnerProducer.ProducerAsync(integrationEvent, headers);
        //}
    }
}
