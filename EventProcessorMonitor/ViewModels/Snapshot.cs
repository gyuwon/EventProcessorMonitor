using System.Collections.Generic;

namespace EventProcessorMonitor.ViewModels
{
    public class Snapshot
    {
        public string EventHubName { get; set; }

        public IEnumerable<ConsumerGroup> ConsumerGroups { get; set; }
    }
}
