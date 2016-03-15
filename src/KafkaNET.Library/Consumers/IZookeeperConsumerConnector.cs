using System.Collections.Generic;
using Kafka.Client.Serialization;

namespace Kafka.Client.Consumers
{
    public interface IZookeeperConsumerConnector : IConsumerConnector
    {
        string ConsumerGroup { get; }

        void AutoCommit();

        string GetConsumerIdString();

        IDictionary<string, IDictionary<int, PartitionTopicInfo>> GetCurrentOwnership();

        void ReleaseAllPartitionOwnerships();
    }
}