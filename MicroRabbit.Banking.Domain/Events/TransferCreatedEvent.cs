using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent :Event
    {
        public int From { get;private set; }
        public int To { get;private set; }
        public decimal Amount { get;private set; }
        public TransferCreatedEvent(int from = 0, int to = 0, decimal amount = 0)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
