﻿using System.Threading.Tasks;
using EducaOnline.Core.Messages;
using EducaOnline.Core.Messages.CommonMessages.DomainEvents;
using EducaOnline.Core.Messages.CommonMessages.Notifications;

namespace EducaOnline.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
        Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent;
    }
}