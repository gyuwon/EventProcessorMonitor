namespace EventProcessorMonitor.ViewModels
{
    public class PartitionLease
    {
        public string PartitionId { get; set; }

        public string Offset { get; set; }

        public int SequenceNumber { get; set; }

        public string Owner { get; set; }

        public string Token { get; set; }

        public int Epoch { get; set; }
    }
}
