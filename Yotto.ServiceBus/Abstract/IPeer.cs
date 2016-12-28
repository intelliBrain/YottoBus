﻿using System;
using System.Collections.Generic;
using System.Net;
using Yotto.ServiceBus.Model;

namespace Yotto.ServiceBus.Abstract
{
    public interface IPeer : IDisposable
    {
        void Connect();
        bool IsConnected { get; }

        PeerIdentity Identity { get; }
        PeerIdentity[] GetConnectedPeers();

        void Subscribe<TEvent>(IEventHandler<TEvent> handler);
        void Unsubscribe<TEvent>(IEventHandler<TEvent> handler);

        void Publish(object @event);

        void Send(object message, PeerIdentity target);

        void Disconnect();
    }
}
