using System.Collections.Generic;

namespace EventProcessorMonitor.Services
{
    public class EventHubService : IEventHubService
    {
        public IEnumerable<string> GetConsumerGroupNames()
        {
            yield break;
        }
    }
}
