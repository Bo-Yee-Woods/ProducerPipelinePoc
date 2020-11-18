using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventbusPoc
{
    public interface IPublisher
    {
        Task PublishAsync<T>(T integrationEvent, IDictionary<string, string> headers);
    }
}