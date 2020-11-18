using Microsoft.Extensions.DependencyInjection;

namespace EventbusPoc
{
    public static class EventbusExtension
    {
        public static DelegatingProducerBuilder AddPublisher(this IServiceCollection services) 
        {
            services.AddSingleton<IPublisher, Publisher>();
            return new DelegatingProducerBuilder(services);
        }
    }
}
