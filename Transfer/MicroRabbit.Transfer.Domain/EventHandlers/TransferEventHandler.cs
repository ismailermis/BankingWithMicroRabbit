﻿using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository = null)
        {
            _transferRepository = transferRepository;
        }

        public Task Handler(TransferCreatedEvent @event)
        {
            _transferRepository.Add(
                new TransferLog()
                {
                    FromAccount= @event.From,
                    ToAccount=@event.To,
                    TransferAmount = @event.Amount
                });
            return Task.CompletedTask;
        }
    }
}
