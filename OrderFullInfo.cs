using System;

namespace MessageBrokerShared
{
    public class OrderFullInfo
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public int ProductId { get; set; }
        public string Status { get; set; }
	    public FunctionType Function { get; set; }
    }
}
