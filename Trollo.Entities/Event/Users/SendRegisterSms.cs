using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trollo.Entities.Event.Users
{
    public sealed class SendRegisterSms : INotificationHandler<UserDomainEvent>
    {
        public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
        {
            //notification.AppUser.Id;
            //Sms Gönderme İşlemi

            return Task.CompletedTask;
        }
    }
}
