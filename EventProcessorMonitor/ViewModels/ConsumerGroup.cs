using System.Collections.Generic;

namespace EventProcessorMonitor.ViewModels
{
    public class ConsumerGroup
    {
        public string ConsumerGroupName { get; set; }

        public IEnumerable<PartitionLease> PartitionLeases { get; set; }
    }
}
