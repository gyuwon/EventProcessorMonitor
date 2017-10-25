using FluentAssertions;
using Xunit;

namespace EventProcessorMonitor.Services
{
    public class EventHubService_specs
    {
        [Fact]
        public void sut_implements_IEventHubService()
        {
            typeof(EventHubService).Should().Implement<IEventHubService>();
        }
    }
}
