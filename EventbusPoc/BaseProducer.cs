using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace EventbusPoc
{
    public class BaseProducer : IDelegatingProducer
    {
        private readonly ILogger<BaseProducer> _logger;

        public BaseProducer(ILogger<BaseProducer> logger)
        {
            _logger = logger;
        }

        public IDelegatingProducer InnerProducer { get; set; }

        public Task ProducerAsync<TEvent>(TEvent integrationEvent, IDictionary<string, string> headers)
        {
            _logger.LogInformation($"KafkaProducer.ProducerAsync => integrationEvent: {JsonSerializer.Serialize(integrationEvent)} headers: {JsonSerializer.Serialize(headers)}");

            return Task.CompletedTask;
        }
    }
}
