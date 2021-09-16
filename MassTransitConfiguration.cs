using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBrokerShared
{
    public static class MassTransitConfiguration
    {
        public const string Uri = "rabbitmq://localhost";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string QueueName = "orders";
    }
}
