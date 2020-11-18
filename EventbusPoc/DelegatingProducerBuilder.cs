using Microsoft.Extensions.DependencyInjection;

namespace EventbusPoc
{
    public class DelegatingProducerBuilder
    {
        private IServiceCollection _serviceCollection;

        public DelegatingProducerBuilder(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public DelegatingProducerBuilder Register<TDelegatingProducer>() where TDelegatingProducer : DelegatingProducer
        {
            _serviceCollection.AddSingleton<IDelegatingProducer, TDelegatingProducer>();

            return this;
        }

        public void AddBaseProducer()
        {
            _serviceCollection.AddSingleton<IDelegatingProducer, BaseProducer>();
        }
    }
}