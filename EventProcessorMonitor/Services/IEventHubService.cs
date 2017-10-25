using System.Collections.Generic;

namespace EventProcessorMonitor.Services
{
    public interface IEventHubService
    {
        IEnumerable<string> GetConsumerGroupNames();
    }
}
